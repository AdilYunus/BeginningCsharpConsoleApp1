using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public class RelatiesDict : DictionaryBase
    {
        public void Add(int nummer, Relatie relatie)
        {
            Dictionary.Add(nummer, relatie);
        }

        public void Remove(int nummer)
        {
            Dictionary.Remove(nummer);
        }

        public Relatie this[int nummer]
        {
            get
            {
                return (Relatie)Dictionary[nummer];
            }
            set
            {
                Dictionary[nummer] = value;
            }
        }
    }
}
