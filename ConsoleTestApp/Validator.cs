using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public class Validator
    {
        private object Target { get; }
        public string BrokenRules { get; private set; }

        public Validator(object target)
        {
            Target = target;
        }

        public bool Validate()
        {
            var meldingen = new StringBuilder();
            Type type = Target.GetType();

            foreach (PropertyInfo propertyInfo in type.GetProperties())
            {
                foreach (Attribute attr in propertyInfo.GetCustomAttributes(true))
                {
                    object waarde = propertyInfo.GetValue(Target);
                    var requiredAtt = attr as IsRequired;

                    if (requiredAtt != null && requiredAtt.Required)
                    {
                        if (!IsRequired.Check(waarde, propertyInfo))
                        {
                            meldingen.AppendLine(string.Format($"{type.Name}.{propertyInfo.Name} is niet gevuld!"));
                        }
                    }

                    var myStringLengthAttribute = attr as MyStringLengthAttribute;
                    if (myStringLengthAttribute != null && propertyInfo.PropertyType == typeof(string))
                    {
                        if (!MyStringLengthAttribute.Check(waarde as string, myStringLengthAttribute.MinLength,
                                myStringLengthAttribute.MaxLength))
                        {
                            meldingen.AppendLine(string.Format($"{type.Name}.{propertyInfo.Name} lengte moet tussen {myStringLengthAttribute.MinLength} en {myStringLengthAttribute.MaxLength} liggen."));

                        }
                    }
                }
       
            }
            BrokenRules = meldingen.ToString();
            return string.IsNullOrEmpty(BrokenRules);
        }

    }
}
