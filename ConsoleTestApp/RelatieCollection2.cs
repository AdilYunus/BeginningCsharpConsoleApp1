using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public class RelatieCollection2<T> : IEnumerable<T> where T : IRelatie
    {
        private  List<T> Relaties = new List<T>();
        public void Add(T relatie)
        {
            Relaties.Add(relatie);
        }

        public bool Remove(T relatie)
        {
            return Relaties.Remove(relatie);
        }
        public T this[int index]
        {
            get => Relaties[index];
            set => Relaties[index] = value;
        }
        public IEnumerator<T> GetEnumerator()
        {
            return Relaties.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
