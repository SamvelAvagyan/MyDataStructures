namespace MyDataStructures
{
    class LinkedList<T>
    {
        private Node<T> _head;
        private Node<T> _tail;
        public int Count { get; private set; }

        public LinkedList()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }

        public LinkedList(T data)
        {
            _head = new Node<T>(data);
            _tail = _head;
            Count = 1;
        }

        public void AddFirst(T data)
        {
            var node = new Node<T>(data);
            node.Next = _head;
            _head = node;
            Count++;
        }

        public void AddLast(T data)
        {
            var node = new Node<T>(data);

            if(_head == null)
            {
                _head = node;
                _tail = _head;
                Count = 1;
            }
            else
            {
                _tail.Next = node;
                _tail = _tail.Next;
                Count++;
            }
        }
    }
}
