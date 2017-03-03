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

        public void Remove(T v)
        {
            throw new NotImplementedException();
        }

        public bool Contains(T v)
        {
            throw new NotImplementedException();
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public void InsertAt(int v, T elementToInsert)
        {
            throw new NotImplementedException();
        }
        public int Index(T segundoElemento)
        {
            throw new NotImplementedException();
        }

        public bool RemoveByIndex(int i)
        {
            throw new NotImplementedException();
        }

        public void Reverse()
        {
            throw new NotImplementedException();
        }

        public bool ChangePosition(int i, int i1)
        {
            throw new NotImplementedException();
        }
    }
}
