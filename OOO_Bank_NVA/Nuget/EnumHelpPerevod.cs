using System;
using System.ComponentModel;
using System.Reflection;

namespace OOO_Bank_NVA.Nuget
{
    public static class EnumHelpPerevod
    {
        public static string PerevodDescription(this Enum en)
        {
            Type type = en.GetType();

            MemberInfo[] memInfo = type.GetMember(en.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }
            return en.ToString();
        }
        public static string Perevod(this Enum en, params string[] rus)
        {
            Type type = en.GetType();

            var i = 0;
            foreach (var c in Enum.GetValues(type))
            {
                if (en.Equals(c))
                {
                    return rus[i];
                }
                i++;
            }
            return "Неизвестно";
        }
    }
}
