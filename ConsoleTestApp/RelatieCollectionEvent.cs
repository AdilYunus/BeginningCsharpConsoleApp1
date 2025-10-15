using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    public delegate void CountEventHandler(object sender, int count);
    public delegate void ChangedEventHandler(object sender, string verbijzondering);


    public class RelatieCollectionEvent<T> : IEnumerable<T> where T : IRelatie
    {
        private const string TOEGEVOEGD = "Toegevoegd"; // added
        private const string VERWIJDERD = "Verwijderd"; // removed


        private List<T> Relaties = new List<T>();

        //exercise 13-3
        public event CountEventHandler EvenCount;
        public event CountEventHandler OddCount;


        public event ChangedEventHandler Changed;

        protected virtual void OnChanged(string verbijzondering)
        {
            if (Changed != null)
            {
                Changed(this, verbijzondering);
            }
        }

        public void Add(T relatie)
        {
            Relaties.Add(relatie);
            OnChanged(TOEGEVOEGD);
            OnCount();

        }

        public bool Remove(T relatie)
        {
            bool removed = Relaties.Remove(relatie);

            if (removed)
            {
                OnChanged(VERWIJDERD);
                OnCount();
            }
            return removed;
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

        protected virtual void OnCount()
        {
            bool isEven = Relaties.Count % 2 == 0;

            if (isEven && EvenCount != null)
            {
                EvenCount(this, Relaties.Count);
            }

            if (!isEven && OddCount != null)
            {
                OddCount(this, Relaties.Count);
            }
        }
    }
}