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
        bool InitPhase = false;

        EVrInsightEquipment VrInsightEquipment = EVrInsightEquipment.other;
        public XPComboTest()
        {
            InitializeComponent();
            InitializeTimer();

            this.Text = "XPComboTest version 1.0 by xprezzo-marco";


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

                Log(ELogger.info, "COMM: opening port " + commPort);
                Log(ELogger.info, "COMM: BaudRate " + SerialPort.BaudRate);
                Log(ELogger.info, "COMM: Parity " + SerialPort.Parity);
                Log(ELogger.info, "COMM: DataBits " + SerialPort.DataBits);
                Log(ELogger.info, "COMM: StopBits " + SerialPort.StopBits);
                Log(ELogger.info, "COMM: RtsEnable " + SerialPort.RtsEnable);
                Log(ELogger.info, "COMM: DtrEnable " + SerialPort.DtrEnable);

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
                Log(ELogger.error, "Exception " + ex.Message);
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
                    Log(ELogger.error, "serial port == null.");
                    return;

                }

                if (!SerialPort.IsOpen)
                {
                    Log(ELogger.error, "serial port is not open yet ");
                    return;

                }

                // combo can only receive 8 digits
                var cmd = command;

                int len = cmd.Length;
                if (len > 8)
                {
                    cmd = command.Substring(0, 8);
                    Log(ELogger.warn, "command [" + command + "] maximum length is 8. Abbreviated to [" + cmd + "]");

                }
                else if (len < 8)
                {
                    for (int i = len; i < 8; i++)
                    {
                        cmd += '\0';
                    }
                    Log(ELogger.warn, "command [" + command + "] length < 8. Length adapted to [" + cmd + "]");

                }



                SerialPort.Write(cmd);
                Log(ELogger.serial_out, cmd + " ----------------->");
            }
            catch (Exception ex)
            {
                Log(ELogger.error, "Exception " + ex.Message);
            }
        }




        void serialDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (SerialPort == null) return;


            try
            {
                var serialData = SerialPort.ReadExisting();

                if (serialData == null)
                {
                    return;
                }

                Log(ELogger.serial_in, "<------------------------- " + serialData);


                if (serialData.StartsWith("CMDCON"))
                {
                    InitPhase = true;
                }
                else if (InitPhase)
                {

                    if (serialData.StartsWith("CMDMCP2B"))
                    {
                        VrInsightEquipment = EVrInsightEquipment.combo2;
                        InitDisplays("    ");

                    }
                    else if (serialData.StartsWith("CMDFMER"))
                    {
                        VrInsightEquipment = EVrInsightEquipment.combo1;
                    }
                    else if (serialData.StartsWith("APLMAST"))
                    {

                        InitDisplays("    ");
                    }
                }
           

                }

            catch (Exception ex)
            {
                Log(ELogger.error, "Exception " + ex.Message);
            }




        }

        void InitDisplays(string pattern)
        {
            InitPhase = false;

            Log(ELogger.info, "InitDisplays: pattern [" + pattern + "]");

            switch (VrInsightEquipment)
            {
                case EVrInsightEquipment.combo1:
                    WriteToSerial("DSP0" + pattern); Delay();
                    WriteToSerial("DSP1" + pattern); Delay();
                    break;

                case EVrInsightEquipment.combo2:

                    /* enjxp
                    * The first line (upper line) goes from DSP0 to DSP7
                    * The second line (lower line) goes from DSP8 to DSPF
                    */

                    WriteToSerial("DSP0" + pattern); Delay();
                    WriteToSerial("DSP8" + pattern); Delay();

                    WriteToSerial("DSP1" + pattern); Delay();
                    WriteToSerial("DSP9" + pattern); Delay();

                    WriteToSerial("DSP2" + pattern); Delay();
                    WriteToSerial("DSPA" + pattern); Delay();

                    WriteToSerial("DSP3" + pattern); Delay();
                    WriteToSerial("DSPB" + pattern); Delay();

                    WriteToSerial("DSP4" + pattern); Delay();
                    WriteToSerial("DSPC" + pattern); Delay();

                    WriteToSerial("DSP5" + pattern); Delay();
                    WriteToSerial("DSPD" + pattern); Delay();

                    WriteToSerial("DSP6" + pattern); Delay();
                    WriteToSerial("DSPE" + pattern); Delay();

                    WriteToSerial("DSP7" + pattern); Delay();
                    WriteToSerial("DSPF" + pattern); Delay();
                    break;

                default:
                    break;

            }
        }

        void DetectDisplays()
        {
            Log(ELogger.info, "DetectDisplays:");

            switch (VrInsightEquipment)
            {
                case EVrInsightEquipment.combo1:
                    WriteToSerial("DSP0" + "0000"); Delay();
                    WriteToSerial("DSP1" + "0001"); Delay();
                    break;

                case EVrInsightEquipment.combo2:

                    /* enjxp
                     * The first line (upper line) goes from DSP0 to DSP7
                     * The second line (lower line) goes from DSP8 to DSPF
                     */


                    WriteToSerial("DSP0" + "0000"); Delay();
                    WriteToSerial("DSP8" + "0008"); Delay();

                    WriteToSerial("DSP1" + "0001"); Delay();
                    WriteToSerial("DSP9" + "0009"); Delay();

                    WriteToSerial("DSP2" + "0002"); Delay();
                    WriteToSerial("DSPA" + "0010"); Delay();

                    WriteToSerial("DSP3" + "0003"); Delay();
                    WriteToSerial("DSPB" + "0011"); Delay();

                    WriteToSerial("DSP4" + "0004"); Delay();
                    WriteToSerial("DSPC" + "0012"); Delay();

                    WriteToSerial("DSP5" + "0005"); Delay();
                    WriteToSerial("DSPD" + "0013"); Delay();

                    WriteToSerial("DSP6" + "0006"); Delay();
                    WriteToSerial("DSPE" + "0014"); Delay();

                    WriteToSerial("DSP7" + "0007"); Delay();
                    WriteToSerial("DSPF" + "0015"); Delay();
                    break;

                default:
                    break;

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

            if (SerialPort != null) { SerialPort.Close(); }

            VrInsightEquipment = EVrInsightEquipment.unknown;
            darkTextBoxVrInsightEquipment.Text = "";

            Log(ELogger.warn, "COMM: selected " + commPort);

            darkButtonConnectToSerial.Enabled = true;
            darkButtonDisconnect.Enabled = !darkButtonConnectToSerial.Enabled;
            darkComboBoxSerialPort.Enabled = darkButtonConnectToSerial.Enabled;

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

            // Run this procedure in an appropriate event.  
            timer2.Interval = 20;
            timer2.Enabled = true;
            // Hook up timer's tick event handler.  
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
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

        private void timer2_Tick(object sender, System.EventArgs e)
        {
            darkTextBoxVrInsightEquipment.Text = VrInsightEquipment.ToString();
        }
        void Log(ELogger logger, string s)
        {

            LogMessage logMessage = new LogMessage(logger, s);
            this._logQueue.Enqueue(logMessage);
        }

        private void darkButtonInitDisplay_Click(object sender, EventArgs e)
        {
            InitDisplays("    ");

        }

        private void darkButtonSetDisplay_Click(object sender, EventArgs e)
        {
            DetectDisplays();
        }
    }
}
