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
using System.Globalization;


namespace XPComboTest.Extensions
{

    public class Util
    {

     

     
       

      
        public static bool HasContent(string value)
        {
            if (value == null || value.Length == 0)
            {
                return false;
            }
            return true;
        }

        public static bool HasContent(bool? value)
        {
            if (!value.HasValue)
            {
                return false;
            }
            return true;
        }

        public static bool HasContent(double? value)
        {
            if (!value.HasValue)
            {
                return false;
            }
            return true;
        }

        public static bool HasContent(int? value)
        {
            if (!value.HasValue)
            {
                return false;
            }
            return true;
        }
        public static bool Getbool(string value, bool defValue)
        {

            if (value == null)
            {
                return defValue;
            }
            return bool.Parse(value);

        }
        public static bool GetBool(string value, bool defValue)
        {

            if (value == null)
            {
                return defValue;
            }

            if (value.ToUpper().StartsWith("Y"))
            {
                return true;
            }

            if (value.ToUpper().StartsWith("N"))
            {
                return false;
            }
            return bool.Parse(value);

        }


        public static double GetDouble(string value, double defValue)
        {
            try
            {
                return Convert.ToDouble(value);
            }
            catch (FormatException)
            {
                return defValue;
            }
            catch (OverflowException)
            {
                return defValue;
            }
        }

        public static int GetInteger(string value, int defValue)
        {
            try
            {
                return Convert.ToInt32(value);
            }
            catch (FormatException)
            {
                return defValue;
            }
            catch (OverflowException)
            {
                return defValue;
            }
        }

        public static float GetFloat(string value, float defValue)
        {
            try
            {
                return float.Parse(value, CultureInfo.InvariantCulture.NumberFormat);

            }
            catch (FormatException)
            {
                return defValue;
            }
            catch (OverflowException)
            {
                return defValue;
            }
        }

        public static long GetLong(string value, long defValue)
        {
            try
            {
                return Convert.ToInt64(value);
            }
            catch (FormatException)
            {
                return defValue;
            }
            catch (OverflowException)
            {
                return defValue;
            }
        }

        public static bool IsTrueOrFalse(string str, bool defaultValue)
        {
            if (!HasContent(str))
            {
                return defaultValue;
            }

            string target = str.ToUpper();


            if ((target.Equals("TRUE") || (target.Equals("Y") || (target.Equals("1")))))
            {
                return true;
            }

            return false;
        }

       
      
    }
}

