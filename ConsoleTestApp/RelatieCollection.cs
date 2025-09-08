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
        public Relatie GetJongst()
        {
            Relatie jongst = null;
            foreach (Relatie r in this)
            {
                if (jongst == null || r.Geboortedatum > jongst.Geboortedatum)
                {
                    jongst = r;
                }
            }
            return jongst;
        }
        public Relatie GetOudest()
        {
            Relatie oudst = null;
            foreach (Relatie r in this)
            {
                if (oudst == null || r.Geboortedatum < oudst.Geboortedatum)
                {
                    oudst = r;
                }
            }
            return oudst;
        }
    }
}
