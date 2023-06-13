using System;

namespace MyDataStructures
{
    class DynamicStack<T>
    {
        private Node<T> _head;
        public int Count { get; private set; }
        public bool IsEmpty => _head == null;

        public DynamicStack()
        {
            _head = null;
            Count = 0;
        }

        public DynamicStack(T data)
        {
            _head = new Node<T>(data);
            Count = 1;
        }

        public void Push(T data)
        {
            if(IsEmpty)
            {
                _head = new Node<T>(data);
                Count = 1;
            }
            else
            {
                var node = new Node<T>(data);
                node.Next = _head;
                _head = node;
                Count++;
            }
        }

        public T Pop()
        {
            if(IsEmpty)
            {
                throw new NullReferenceException("Stack is empty");
            }
            else
            {
                var current = _head.Data;
                _head = _head.Next;
                Count--;
                return current;
            }
        }

        public T Peek()
        {
            if (IsEmpty)
            {
                throw new NullReferenceException("Stack is empty");
            }
            else
            {
                Count--;
                return _head.Data;
            }
        }
    }
}
