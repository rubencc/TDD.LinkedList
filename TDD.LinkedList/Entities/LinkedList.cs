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
            list.Add(v);
        }

        public T Get()
        {
            return this.list.Last();
        }
    }
}
