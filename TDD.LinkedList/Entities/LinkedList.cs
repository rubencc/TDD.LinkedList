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

        public void Push(T data)
        {
            
        }

        public void PushAfter(Node<T> node, T data)
        {

        }

        public void PushBefore(Node<T> node, T data)
        {

        }

        public T Pop()
        {
            return null;
        }

        public T Pop(int index)
        {
            return null;
        }

        public void Remove(T data)
        {
            
        }

        public int Count()
        {
            return 0;
        }

        public void Clear()
        {
            
        }
    }
}
