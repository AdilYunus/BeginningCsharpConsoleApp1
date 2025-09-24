using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public static class RelatieExtensions
    {
        public static string GeboortedatumFormat(this Relatie12 relatie, string format ="dd-mm-yyy")
        {
            return relatie.Geboortedatum.ToString(format);
        }
    }
}
