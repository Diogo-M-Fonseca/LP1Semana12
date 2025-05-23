using System;
using System.Collections;
using System.Collections.Generic;

namespace JustLikeACollection
{

    public class Guarda3<T> : IEnumerable<T>, IEnumerable
    {
        private T Guarda31;
        private T Guarda32;
        private T Guarda33;
        public Guarda3()
        {
            Guarda31 = default;
            Guarda32 = default;
            Guarda33 = default;
        }

        public void Add(T item)
        {
            if (Guarda31 == null || Guarda31.Equals(default(T)))
            {
                Guarda31 = item;
            }
            else if (Guarda32 == null || Guarda32.Equals(default(T)))
            {
                Guarda32 = item;
            }
            else if (Guarda33 == null || Guarda33.Equals(default(T)))
            {
                Guarda33 = item;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            yield return Guarda31;
            yield return Guarda32;
            yield return Guarda33;
        }
        public T GetItem(int i)
        {
            switch (i)
            {
                case 0: return Guarda31;
                case 1: return Guarda32;
                case 2: return Guarda33;
                default: throw new IndexOutOfRangeException();
            }

        }
        public void SetItem(int i, T item)
        {
            switch (i)
            {
                case 0:
                    Guarda31 = item;
                    break;
                case 1:
                    Guarda32 = item;
                    break;
                case 2:
                    Guarda33 = item;
                    break;
                default:
                    throw new IndexOutOfRangeException();
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}