using System;

namespace Lenovo.CIS.EAS.cUI
{

    /// <summary>
    ///扩展类
    /// </summary>
    public static class StringExtend
    {
        /// <summary>
        /// 转字符串控制类
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string NullToStr(this object value)
        {
            if (value == null || value is DBNull)
                return "";
            return value.ToString();
        }
        /// <summary>
        /// 字符串转Int
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static Int32 NullToInt(this object value)
        {
            if (value == null || value is DBNull)
                return 0;
            if (value is Enum)
                return value.GetHashCode();
            return Convert.ToInt32(value.ToString());
        }

        /// <summary>
        /// 字符串转Long
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static long NullToLong(this object value)
        {
            if (value == null || value is DBNull)
                return 0;
            if (value is Enum)
                return value.GetHashCode();
            return Convert.ToInt64(value.ToString());
        }

        /// <summary>
        /// 字符串转Decimal
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static decimal NullToDecimal(this object value)
        {
            if (value == null || value is DBNull)
                return 0;
            if (value is Enum)
                return value.GetHashCode();
            decimal res = 0;
            try
            {
                res = Convert.ToDecimal(value);
            }
            catch
            {
                // ignored
            }
            return res;
        }

        public static string ToNULL(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return null;
            return value;
        }

        /// <summary>
        /// 转换时间。不正确的话，返回当前时间
        /// </summary>
        /// <param name="isdt">要转换的字符串</param>
        /// <returns></returns>
        public static DateTime ToDateTime(this string isdt)
        {
            //判断时间是否正确
            DateTime mydt;
            try
            {
                mydt = Convert.ToDateTime(isdt);
            }
            catch
            {
                //时间格式不正确
                return mydt = DateTime.Now;
            }

            return mydt;
        }


        /// <summary>
        /// 根据枚举value 获取枚举名称
        /// </summary>
        /// <param name="value"></param>
        /// <param name="enumType">typeof(枚举类)</param>
        /// <returns></returns>
        public static string NullToEnumName(this object value, Type enumType)
        {
            if (value == null || value is DBNull)
                return "未知";
            var str = Enum.GetName(enumType, value.NullToInt());
            if (string.IsNullOrEmpty(str))
                return "未知";
            else
                return str;
        }
    }
}
