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

using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace XPComboTest
{
    public class LogMessage
    {
        public Color Fg { get; set; }
        public string Message { get; set; }

        public LogMessage(ELogger logger, string message)
        {

            Fg = Color.White;
            Message = logger.ToString() + ": " +  message;
            switch (logger)
            {

                case ELogger.warn:
                    Fg = Color.Orange;
                    break;

                case ELogger.error:
                    Fg = Color.Red;
                    break;

                case ELogger.serial_out:
                    Fg = Color.Cyan;
                    break;

                case ELogger.serial_in:
                    Fg = Color.Violet;
                    break;

                case ELogger.delay:
                    Fg = Color.Yellow;
                    break;
                default:
                    break;

            }
        }

    

        public void ToLogger(RichTextBox rt, Color bgColorMessage)
        {
            rt.SelectionStart = rt.TextLength;
            rt.SelectionLength = 0;
            rt.SelectionColor = Fg;
            rt.SelectionBackColor = bgColorMessage;


            rt.AppendText((rt.Lines.Count() == 0 ? "" : Environment.NewLine) + DateTime.Now + ": " + Message);
            rt.SelectionBackColor = Fg;
            rt.SelectionColor = bgColorMessage;

            rt.SelectionStart = rt.Text.Length;
            rt.ScrollToCaret();
            rt.Refresh();



        }
    }
}
