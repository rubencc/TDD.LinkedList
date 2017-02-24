using System;
using System.ComponentModel;
using System.Text;

namespace TDD.LinkedList
{
    public sealed class LinkedList<T>
        where T : class
    {
        private Node<T> head;

        public LinkedList()
        {
            this.head = null;
        }

        public void Add(T data)
        {
            if (this.head == null)
            {
                this.head = new Node<T>(data);
            }
            else
            {
                Node<T> current = this.head.GetNext();

                if (current == null)
                {
                    this.head.SetNext(new Node<T>(data));
                    return;
                }

                while (current.GetNext() != null)
                {
                    current = current.GetNext();
                }
                
                current.SetNext(new Node<T>(data));
            }        
        }

        public T Get()
        {
            Node<T> node = this.head;

            if (node.GetNext() != null)
            {
                this.SetNextIntoHead(node);
            }

            return node.Content;
        }

        public void Remove(T data)
        {
            Node<T> current = this.head;

            Tuple<Node<T>, Node<T>, int> pointer = this.GetPointerByData(this.head, data);

            if (pointer.Item1 == pointer.Item2)
            {
                this.SetNextIntoHead(current);
                return;
            }

            if (pointer.Item1 != null)
            {
                pointer.Item1.SetNext(pointer.Item2.GetNext());
            }

        }

        public bool Find(T data)
        {
            Tuple<Node<T>, Node<T>, int> pointer = this.GetPointerByData(this.head, data);

            if (pointer.Item1 == null)
                return false;

            return pointer.Item2.Content == data;
        }

        public int FindIndex(T data)
        {
            return this.GetPointerByData(this.head, data).Item3;
        }

        private Tuple<Node<T>, Node<T>, int> GetPointerByData(Node<T> node, T data)
        {
            Node<T> current = node;

            if (this.head.Content == data)
            {
                return new Tuple<Node<T>, Node<T>, int>(this.head, node, 0);
            }
            int i = 0;

            while (node.GetNext() != null)
            {
                if (node.GetNext().Content == data)
                {
                    Node<T> before = node;
                    node = node.GetNext();
                    return new Tuple<Node<T>, Node<T>, int>(before, node, i+1);
                }
                node = node.GetNext();
                i++;
            }

            return new Tuple<Node<T>, Node<T>, int>(null, current, -1);
        }

        private void SetNextIntoHead(Node<T> current)
        {
            this.head = current.GetNext();
        }


        public int Count => this.GetCount();

        private int GetCount()
        {
            if (this.head == null)
                return 0;

            int i = 1;

            Node<T> current = this.head;

            while (current.GetNext() != null)
            {
                i++;
                current = current.GetNext();
            }

            return i;
        }

        public void Clear()
        {
            this.head = null;
        }

        public override string ToString()
        {
            if(this.head == null)
                return String.Empty;

            StringBuilder sb = new StringBuilder();

            sb.Append(this.head.ToString());

            Node<T> current = this.head.GetNext();

            while (current != null)
            {
                sb.Append(", ");
                sb.Append(current.ToString());
                current = current.GetNext();
                
            }

            return sb.ToString();
        }
    }
}
