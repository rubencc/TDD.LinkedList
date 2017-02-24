using System;

namespace TDD.LinkedList
{
    public sealed class Node<T> where T: class
    {
        private Node<T> next;
        public T Content { get; }

        public Node(T data)
        {
            if (data == null)
                throw new ArgumentNullException();
            this.Content = data;
        }

        public void SetNext(Node<T> node)
        {
            if(node != null)
                this.next = node;
        }

        public Node<T> GetNext()
        {
            return this.next;
        }

        public override string ToString()
        {
            return this.Content.ToString();
        }
    }
}
