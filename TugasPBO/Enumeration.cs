using System;
using System.Collections.Generic;
using System.Reflection;
using System.ComponentModel;
using System.Text;

namespace TugasPBO
{
    class Enumeration
    {
        public string GetEnumDesc(Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] atribut = (DescriptionAttribute[])fi.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (atribut != null && atribut.Length > 0)
            {
                return atribut[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }
    }
}
