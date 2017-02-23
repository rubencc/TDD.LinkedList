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
    }
}
