using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public sealed class IsRequired : Attribute
    {
        public bool Required { get; private set; }
        public IsRequired(bool required)
        {
            Required = required;
        }
        public static bool Check(object waarde, PropertyInfo propertyInfo)
        {
            if (propertyInfo.PropertyType == typeof(string))
            {
                var tekstWaarde = Convert.ToString(waarde);
                if (string.IsNullOrEmpty(tekstWaarde) || string.IsNullOrWhiteSpace(tekstWaarde))
                {
                    // Fout: deze property had een waarde moeten hebben              
                    return false;
                }
            }

            else if (propertyInfo.PropertyType == typeof(short) || propertyInfo.PropertyType == typeof(int)
                                                                || propertyInfo.PropertyType == typeof(long))
            {

                var numWaarde = Convert.ToInt64(waarde);

                if (numWaarde == 0)
                {
                    // Fout: deze property had een waarde moeten hebben
                    return false;
                }
            }

            else if (propertyInfo.PropertyType == typeof(DateTime))
            {
                var datumWaarde = Convert.ToDateTime(waarde);
                if (datumWaarde == DateTime.MinValue)
                {
                    // Fout: deze property had een waarde moeten hebben                    
                    return false;

                }

            }

            return true;

        }

    }
}

