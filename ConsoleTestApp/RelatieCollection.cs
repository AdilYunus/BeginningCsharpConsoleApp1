using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    internal class RelatieCollection : CollectionBase
    {
        public void Add(Relatie relatie)
        {
            List.Add(relatie);
        }

        public void Remove(Relatie relatie)
        {
            List.Remove(relatie);
        }

        public Relatie this[int index]
        {
            get
            {
                return (Relatie)List[index];
            }
            set
            {
                List[index] = value;
            }
        }
    }
}
