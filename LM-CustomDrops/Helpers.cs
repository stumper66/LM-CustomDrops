using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM_CustomDrops
{
    public static class Helpers
    {
        public static bool GetBool(object Input)
        {
            if (Input == null || Input == DBNull.Value)
                return false;

            return Convert.ToBoolean(Input);
        }

        public static int GetInt(object Input, int DefaultValue)
        {
            if (Input == null || Input == DBNull.Value)
                return DefaultValue;

            return Convert.ToInt32(Input);
        }

        public static double GetDouble(object Input, double DefaultValue)
        {
            if (Input == null || Input == DBNull.Value)
                return DefaultValue;

            return Convert.ToDouble(Input);
        }

        public static double? GetDoubleN(object Input)
        {
            if (Input == null || Input == DBNull.Value)
                return null;

            return Convert.ToDouble(Input);
        }

        public static string GetString(object Input)
        {
            if (Input == null || Input == DBNull.Value)
                return null;

            return (string)Input;
        }
    }
}
