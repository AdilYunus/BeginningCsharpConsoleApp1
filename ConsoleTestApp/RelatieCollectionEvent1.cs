using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTestApp
{
    internal class RelatieCollectionEvent1<T> : IEnumerable<T> where T : IRelatie
    {
        private const string TOEGEVOEGD = "Toegevoegd";
        private const string VERWIJDERD = "Verwijderd";

        private readonly List<T> Relaties = new List<T>();

        public event EventHandler<ChangedEventArgs> Changed;
        public event EventHandler<CountEventArgs> CountChanged;

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

        protected virtual void OnChanged(string verbijzondering)
        {
            Changed?.Invoke(this, new ChangedEventArgs { Verbijzondering = verbijzondering });
        }

        protected virtual void OnCount()
        {
            CountChanged?.Invoke(this, new CountEventArgs { Count = Relaties.Count });
        }

        public IEnumerator<T> GetEnumerator() => Relaties.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
