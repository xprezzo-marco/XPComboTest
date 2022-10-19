/*
MIT LICENSE

Copyright 2022 xprezzo-marco https://forums.x-plane.org/index.php?/profile/1027037-xprezzo-marco/

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files 
(the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge,
publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so,
subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO 
THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF 
CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER 
DEALINGS IN THE SOFTWARE.
*/

using DarkUI.Forms;

using System;
using System.Collections.Concurrent;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPComboTest
{
    public partial class XPComboTest : DarkForm
    {


        SerialPort SerialPort;
        string commPort;
        ConcurrentQueue<LogMessage> _logQueue = new ConcurrentQueue<LogMessage>();


        public XPComboTest()
        {
            InitializeComponent();
            InitializeTimer();


            darkGroupBoxSerial.Enabled = false;
            darkButtonConnectToSerial.Enabled = false;



            darkComboBoxSerialPort.Sorted = true;




            foreach (var com in SerialPort.GetPortNames())
            {
                darkComboBoxSerialPort.Items.Add(com);
            }

            darkComboBoxBaudRate.Items.Add(115200);
            darkComboBoxBaudRate.SelectedItem = 115200;

            darkComboBoxHandShake.Items.Add(Handshake.None);
            darkComboBoxHandShake.Items.Add(Handshake.XOnXOff);
            darkComboBoxHandShake.Items.Add(Handshake.RequestToSend);
            darkComboBoxHandShake.Items.Add(Handshake.RequestToSendXOnXOff);

            darkComboBoxHandShake.SelectedItem = Handshake.RequestToSendXOnXOff;

            darkComboBoxParity.Items.Add(Parity.None);
            darkComboBoxParity.Items.Add(Parity.Odd);
            darkComboBoxParity.Items.Add(Parity.Even);
            darkComboBoxParity.Items.Add(Parity.Mark);
            darkComboBoxParity.Items.Add(Parity.Space);


            darkComboBoxParity.SelectedItem = Parity.None;

            darkComboBoxDataBits.Items.Add(7);
            darkComboBoxDataBits.Items.Add(8);

            darkComboBoxDataBits.SelectedItem = 8;

            darkComboBoxStopBits.Items.Add(StopBits.None);
            darkComboBoxStopBits.Items.Add(StopBits.One);
            darkComboBoxStopBits.Items.Add(StopBits.Two);
            darkComboBoxStopBits.Items.Add(StopBits.OnePointFive);

            darkComboBoxStopBits.SelectedItem = StopBits.One;


            darkComboBoxToCombo.Items.Add("DSP0ZIBO");
            darkComboBoxToCombo.Items.Add("DSP1TEST");
            darkComboBoxToCombo.Items.Add("DSP0XPRE");
            darkComboBoxToCombo.Items.Add("DSP1ZO  ");

            darkComboBoxToCombo.Items.Add("SPD200.0");
            darkComboBoxToCombo.Items.Add("SPD300.0");
            darkComboBoxToCombo.Items.Add("SPD400.0");

            darkComboBoxToCombo.Items.Add("HDG000.0");
            darkComboBoxToCombo.Items.Add("HDG090.0");
            darkComboBoxToCombo.Items.Add("HDG180.0");

            darkComboBoxToCombo.Items.Add("ALT200.0");
            darkComboBoxToCombo.Items.Add("ALT300.0");
            darkComboBoxToCombo.Items.Add("ALT400.0");

            darkComboBoxToCombo.Items.Add("CMDRST\0\0");
            darkComboBoxToCombo.Items.Add("CMDCON\0\0");
            darkComboBoxToCombo.Items.Add("CMDFUN\0\0");
            darkComboBoxToCombo.Items.Add("CMDVER\0\0");

            darkComboBoxToCombo.SelectedItem = "DSP0ZIBO";
        }
       



        private void darkButtonConnectToSerial_Click(object sender, EventArgs e)
        {
            try
            {
                if (commPort == null)
                {
                    MessageBox.Show("No com port selected",
                                        "Please Select a com port first",
                                        MessageBoxButtons.OK);
                    return;
                }

                darkButtonConnectToSerial.Enabled = false;
                darkButtonDisconnect.Enabled = !darkButtonConnectToSerial.Enabled;

                darkGroupBoxSerial.Enabled = true;

                // Create a new SerialPort object with default settings.  
                SerialPort = new SerialPort
                {
                    PortName = commPort,
                    BaudRate = (int)darkComboBoxBaudRate.SelectedItem,

                    Parity = (Parity)darkComboBoxParity.SelectedItem,
                    DataBits = (int)darkComboBoxDataBits.SelectedItem,
                    StopBits = (StopBits)darkComboBoxStopBits.SelectedItem,
                    Handshake = (Handshake)darkComboBoxHandShake.SelectedItem,
                };

                SerialPort.RtsEnable = darkCheckBoxRtsEnable.Checked;
                SerialPort.DtrEnable = darkCheckBoxDtrEnable.Checked;

                SerialPort.DataReceived += new SerialDataReceivedEventHandler(serialDataReceived);

                Log(ELogger.info,  "COMM: opening port " + commPort);
                Log(ELogger.info,  "COMM: BaudRate " + SerialPort.BaudRate);
                Log(ELogger.info,  "COMM: Parity " + SerialPort.Parity);
                Log(ELogger.info,  "COMM: DataBits " + SerialPort.DataBits);
                Log(ELogger.info,  "COMM: StopBits " + SerialPort.StopBits);
                Log(ELogger.info,  "COMM: RtsEnable " + SerialPort.RtsEnable);
                Log(ELogger.info,  "COMM: DtrEnable " + SerialPort.DtrEnable);

                // Set the read/write timeouts
                //SerialPort.ReadTimeout = 500;
                //SerialPort.WriteTimeout = 500;

                SerialPort.Open();



                if (darkCheckBoxCMDRST.Checked)
                {
                    WriteToSerial("CMDRST\0\0");
                    Delay();
                }
                if (darkCheckBoxCMDCON.Checked)
                {
                    WriteToSerial("CMDCON\0\0");
                    Delay();

                }
                if (darkCheckBoxCMDFUN.Checked)
                {
                    WriteToSerial("CMDFUN\0\0");
                    Delay();

                }

                if (darkCheckBoxCMDVER.Checked)
                {
                    WriteToSerial("CMDVER\0\0");
                    Delay();

                }



            }
            catch (Exception ex)
            {
                Log(ELogger.error,  "Exception " + ex.Message);
            }





        }

        void Delay()
        {
            var millisecondsDelay = (int)darkNumericUpDownDelay.Value;
            if (millisecondsDelay <= 0)
            {
                return;
            }

            Log(ELogger.delay, "Delay: " + millisecondsDelay);
            Task.Delay(millisecondsDelay);

        }


       

        void WriteToSerial(string command)
        {
          

            try
            {
                if (SerialPort == null)
                {
                    Log(ELogger.error,  "serial port == null.");
                    return;

                }

                if (!SerialPort.IsOpen)
                {
                    Log(ELogger.error,  "serial port is not open yet ");
                    return;

                }

                // combo can only receive 8 digits
                var cmd = command;

                int len = cmd.Length;
                if (len > 8)
                {
                    cmd = command.Substring(0, 8);
                    Log(ELogger.warn,  "command ["+command + "] maximum length is 8. Abbreviated to [" + cmd + "]");

                }
                else if (len < 8)
                {
                    for (int i = 0; i < len; i++)
                    {
                        cmd += '\0';
                    }
                    Log(ELogger.warn,  "command [" + command + "] length < 8. Length adapted to [" + cmd + "]");

                }

             

                SerialPort.Write(cmd);
                Log(ELogger.serial_out,cmd + " ----------------->");
            }
            catch (Exception ex)
            {
                Log(ELogger.error,  "Exception " + ex.Message);
            }
        }




        void serialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (SerialPort == null) return;


            try
            {
                var serialData = SerialPort.ReadExisting();

                Log(ELogger.serial_in, "<------------------------- " +serialData);
            }

            catch (Exception ex)
            {
                Log(ELogger.error, "Exception " + ex.Message);
            }




        }



       // private void si_DataReceived(string data) { Log(data); }

        private void darkComboBoxSerialPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            commPort = (string)darkComboBoxSerialPort.SelectedItem;
            Log(ELogger.info, "COMM: selected " + commPort);

            darkButtonConnectToSerial.Enabled = true;
        }

        private void darkButtonDisconnect_Click(object sender, EventArgs e)
        {

            if(SerialPort == null) { return; }
            SerialPort.Close();
            Log(ELogger.warn,  "COMM: selected " + commPort);

            darkButtonConnectToSerial.Enabled = true;
            darkButtonDisconnect.Enabled = !darkButtonConnectToSerial.Enabled;
            darkComboBoxSerialPort.Enabled = darkButtonConnectToSerial.Enabled;
            
        }

        private void darkButton5_Click(object sender, EventArgs e)
        {
            WriteToSerial((string)darkComboBoxToCombo.SelectedItem);
        }

        private void darkButton2_Click(object sender, EventArgs e)
        {
            WriteToSerial(darkTextBoxFreeFormat.Text);

        }

        private void darkButton3_Click(object sender, EventArgs e)
        {

            Stream myStream;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {

        

                    richTextBoxLog.SaveFile(myStream, RichTextBoxStreamType.PlainText);
                    myStream.Close();
                }
            }

           
        }

        private void darkButton1_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Clear();
        }

        private void InitializeTimer()
        {
            // Run this procedure in an appropriate event.  
            timer1.Interval = 20;
            timer1.Enabled = true;
            // Hook up timer's tick event handler.  
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);

          
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            int added = 0;
            while (true)
            {
                bool succes = _logQueue.TryDequeue(out LogMessage logMessage);
                if (!succes)
                {
                    if (added == 0)
                    {
                        return;
                    }

                    return;
                }
                logMessage.ToLogger(richTextBoxLog, Color.Black);



                added++;



            }
        }

        void Log(ELogger logger, string s)
        {

            LogMessage logMessage = new LogMessage(logger, s);
            this._logQueue.Enqueue(logMessage);
        }
    }
}
