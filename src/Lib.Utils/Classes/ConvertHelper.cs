using System;

namespace Lib.Utils.Classes
{
    public class ConvertHelper
    {
        public static string DateToLetter(DateTime _data)
        {
            string ddMMyyyy = _data.ToString("ddMMyyyy");

            string strDate = @"0123456789";
            string strLetter = @"ABCDEFGHIJ";
            for (int i = 0; i < strDate.Length; i++)
                ddMMyyyy = ddMMyyyy.Replace(strDate[i], strLetter[i]);

            return ddMMyyyy.ToUpper();
        }

        public static short ToInt16(object _value, short defaltulValue = 0)
        {
            try
            {
                if (_value == null || string.IsNullOrWhiteSpace(_value.ToString()) || _value.ToString() == "0")
                    return defaltulValue;
                return Convert.ToInt16(_value);
            }
            catch
            {
                return defaltulValue;
            }
        }
        public static int ToInt32(object _value, int defaltulValue = 0)
        {
            try
            {
                if (_value == null || string.IsNullOrWhiteSpace(_value.ToString()) || _value.ToString() == "0")
                    return defaltulValue;
                return Convert.ToInt32(_value);
            }
            catch
            {
                return defaltulValue;
            }
        }
        public static long ToInt64(object _value, long defaltulValue = 0)
        {
            try
            {
                if (_value == null || string.IsNullOrWhiteSpace(_value.ToString()) || _value.ToString() == "0")
                    return defaltulValue;
                return Convert.ToInt64(_value);
            }
            catch
            {
                return defaltulValue;
            }
        }
        public static float ToSingle(object _value, float defaltulValue = 0f)
        {
            try
            {
                if (_value == null || string.IsNullOrWhiteSpace(_value.ToString()) || _value.ToString() == "0" ||
                    _value.ToString() == "0.0" || _value.ToString() == "0.00" || _value.ToString() == "0.000" || _value.ToString() == "0.0000" || _value.ToString() == "0.00000" || _value.ToString() == "0.000000" ||
                    _value.ToString() == "0,0" || _value.ToString() == "0,00" || _value.ToString() == "0,000" || _value.ToString() == "0,0000" || _value.ToString() == "0,00000" || _value.ToString() == "0,000000")
                    return defaltulValue;
                return Convert.ToSingle(_value);
            }
            catch
            {
                return defaltulValue;
            }
        }
        public static double ToDouble(object _value, double defaltulValue = 0d)
        {
            try
            {
                if (_value == null || string.IsNullOrWhiteSpace(_value.ToString()) || _value.ToString() == "0" ||
                    _value.ToString() == "0.0" || _value.ToString() == "0.00" || _value.ToString() == "0.000" || _value.ToString() == "0.0000" || _value.ToString() == "0.00000" || _value.ToString() == "0.000000" ||
                    _value.ToString() == "0,0" || _value.ToString() == "0,00" || _value.ToString() == "0,000" || _value.ToString() == "0,0000" || _value.ToString() == "0,00000" || _value.ToString() == "0,000000")

                    return defaltulValue;
                return Convert.ToDouble(_value);
            }
            catch
            {
                return defaltulValue;
            }
        }
        public static decimal ToDecimal(object _value, decimal defaltulValue = 0m)
        {
            try
            {
                if (_value == null || string.IsNullOrWhiteSpace(_value.ToString()) || _value.ToString() == "0" ||
                    _value.ToString() == "0.0" || _value.ToString() == "0.00" || _value.ToString() == "0.000" || _value.ToString() == "0.0000" || _value.ToString() == "0.00000" || _value.ToString() == "0.000000" ||
                    _value.ToString() == "0,0" || _value.ToString() == "0,00" || _value.ToString() == "0,000" || _value.ToString() == "0,0000" || _value.ToString() == "0,00000" || _value.ToString() == "0,000000")
                    return defaltulValue;
                return Convert.ToDecimal(_value);
            }
            catch
            {
                return defaltulValue;
            }
        }
        public static bool ToBoolean(object _value, bool defaltulValue = false)
        {
            try
            {
                if (_value == null || string.IsNullOrWhiteSpace(_value.ToString()))
                    return defaltulValue;
                return Convert.ToBoolean(_value);
            }
            catch
            {
                return defaltulValue;
            }
        }
        public static string ToString(object _value, string defaltulValue = "")
        {
            try
            {
                if (_value == null || string.IsNullOrWhiteSpace(_value.ToString()))
                    return defaltulValue;
                return Convert.ToString(_value);
            }
            catch
            {
                return defaltulValue;
            }
        }
        public static DateTime ToDateTime(object _value, DateTime? defaltulValue = null)
        {
            try
            {
                if (_value == null || string.IsNullOrWhiteSpace(_value.ToString()))
                    return defaltulValue == null ? DateTime.MinValue : defaltulValue.Value;
                return Convert.ToDateTime(_value);
            }
            catch
            {
                return defaltulValue == null ? DateTime.MinValue : defaltulValue.Value;
            }
        }
        public static DateTime ToDateTimeWithDefault(object _value, DateTime defaultValue)
        {
            try
            {
                if (_value == null || string.IsNullOrWhiteSpace(_value.ToString()))
                    return defaultValue;
                return Convert.ToDateTime(_value);
            }
            catch
            {
                return defaultValue;
            }
        }
        public static DateTime ToDateTime_yyyyMMdd(string _value)
        {
            try
            {
                return new DateTime
                    (Convert.ToInt32(_value.Substring(0, 4)),
                     Convert.ToInt32(_value.Substring(4, 2)),
                     Convert.ToInt32(_value.Substring(6, 2)));
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new ArgumentOutOfRangeException("Erro ao tentar converter Data: " + _value.ToString());
            }
        }
        public static DateTime ToDateTime_ddMMyyyy(string _value)
        {
            try
            {
                return new DateTime
                    (Convert.ToInt32(_value.Substring(4, 4)),
                     Convert.ToInt32(_value.Substring(2, 2)),
                     Convert.ToInt32(_value.Substring(0, 2)));
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new ArgumentOutOfRangeException("Erro ao tentar converter Data: " + _value.ToString());
            }
        }
        public static DateTime? ToDateTimeOrNull(object _value)
        {
            try
            {
                if (_value == null)
                    return null;
                return Convert.ToDateTime(_value);
            }
            catch
            {
                return null;
            }
        }
    }
}
