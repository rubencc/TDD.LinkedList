using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace TDD.LinkedList
{
    public sealed class LinkedList<T>
        where T : class
    {

        private List<T> list;

        public LinkedList()
        {
            this.list = new List<T>();
        }

        public int Count()
        {
            return list.Count;
        }

        public void Add(T v)
        {
            if (v != null)
            {
                list.Add(v);
            }
        }

        public T Get()
        {
            return this.list.Last();
        }

        public void Remove(string v)
        {
            throw new NotImplementedException();
        }

        public bool Contains(string v)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public int Index(string segundoElemento)
        {
            throw new NotImplementedException();
        }
    }
}
