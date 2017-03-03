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

        private Node<T> header; 
        private Node<T> node; 

        public int Count()
        {

            var count = 1;

            if (node == null || node.Content == null)
            {
                return 0;
            }

            while (node.GetNext() != null)
            {

                count++;

                var next = node.GetNext();

                node.SetNext(next);
                
            }

            return count;

        }

        public void Add(T v)
        {
            if (node == null && v != null)
            {
                node = new Node<T>(v);
                return;
            }

            if (v != null)
            {
                node.SetNext(new Node<T>(v));
            }
        }

        public T Get()
        {
            return this.node.Content;
        }

        public void Remove(string v)
        {
            throw new NotImplementedException();
        }

        public T Search(T v)
        {

            T el = null;

            if (node == null)
            {
                throw new ArgumentException();
            }

            if (node.Content.Equals(v))
            {
                el = node.Content;
                return el;
            }

            while (node.GetNext() != null)
            {
               

                var next = node.GetNext();

                node.SetNext(next);
                if (node.GetNext().Content.Equals(v))
                {
                    el = node.GetNext().Content;
                }

            }


            return el;
        }
    }
}
