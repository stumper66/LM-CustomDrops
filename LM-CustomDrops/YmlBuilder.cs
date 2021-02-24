using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LM_CustomDrops
{
    public class YmlBuilder
    {
        public YmlBuilder() 
        {
            MainSB = new StringBuilder();
            m_MobCount = 0;
        }

        private StringBuilder MainSB;
        public int CurrentWhiteSpace;
        private int m_MobCount;

        public void WriteNewMobOrGroup(string Name)
        {
            if (m_MobCount > 0) MainSB.AppendLine();
            CurrentWhiteSpace = 0;
            MainSB.AppendLine(Name.ToUpper() + ":");
            CurrentWhiteSpace = 2;
            m_MobCount++;
        }

        private static string GetWhiteSpace(int Amount)
        {
            if (Amount == 0) return string.Empty;

            return new string(' ', Amount);
        }

        public void WriteValue(string Name, object Value)
        {
            MainSB.Append(GetWhiteSpace(CurrentWhiteSpace));
            MainSB.Append(Name);
            MainSB.Append(":");
            if (Value != null)
            {
                MainSB.Append(" ");
                if (Value is string)
                    MainSB.AppendFormat("'{0}'", Value);
                else if (Value is bool)
                    MainSB.Append(Value.ToString().ToLower());
                else
                    MainSB.Append(Value);
            }
            MainSB.AppendLine();
        }

        public void WriteArrayValue(string Value)
        {
            WriteArrayValue(Value, false);
        }

        public void WriteArrayValue(string Value, bool ContainsSubValues)
        {
            WriteArrayValue(Value, ContainsSubValues, false);
        }

        public void WriteArrayValue(string Value, bool ContainsSubValues, bool UseSingleQuotes)
        {
            MainSB.Append(GetWhiteSpace(CurrentWhiteSpace));
            MainSB.Append("- ");
            if (UseSingleQuotes) MainSB.Append("'");
            MainSB.Append(Value);
            if (UseSingleQuotes) MainSB.Append("'");
            if (ContainsSubValues) MainSB.Append(":");
            MainSB.AppendLine();

            if (ContainsSubValues) CurrentWhiteSpace += 4;
        }

        public string GetFinalString()
        {
            return MainSB.ToString();
        }
    }
}
