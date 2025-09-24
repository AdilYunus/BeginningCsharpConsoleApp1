using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]

    public sealed class MyStringLengthAttribute : Attribute
    {
        public int MinLength { get; }
        public int MaxLength { get; }
        public MyStringLengthAttribute(int minLength, int maxLength)
        {
            MinLength = minLength;
            MaxLength = maxLength;
        }

        public static bool Check(string value,int min, int max)
        {
            
            return value.Length >= min && value.Length <= max;
        }
    }
}
