using System;
using System.Collections;

namespace MyDataStructures
{
    class LinkedList<T> : IEnumerable
    {
        private Node<T> _head;
        private Node<T> _tail;
        public int Count { get; private set; }
        public bool IsEmpty => Count == 0;

        public LinkedList()
        {
            InitiateList();
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

            if (IsEmpty)
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

        public void AddAfter(T target, T data)
        {
            if (IsEmpty)
            {
                throw new NullReferenceException("List is empty");
            }
            else
            {
                var node = new Node<T>(data);

                var current = _head;

                while (current != null)
                {
                    if (current.Data.Equals(target))
                    {
                        node.Next = current.Next;
                        current.Next = node;
                        Count++;
                        return;
                    }

                    current = current.Next;
                }
            }
        }

        public void Remove(T data)
        {
            if (IsEmpty)
            {
                throw new NullReferenceException("List is empty");
            }
            else
            {
                if (_head.Data.Equals(data))
                {
                    _head = _head.Next;
                    Count--;
                    return;
                }

                var current = _head.Next;
                var previous = _head;

                while(current != null)
                {
                    if(current.Data.Equals(data))
                    {
                        previous.Next = current.Next;
                        Count--;
                        return;
                    }

                    previous = current;
                    current = current.Next;
                }
            }
        }

        public void RemoveFirst()
        {
            if (IsEmpty)
            {
                throw new NullReferenceException("List is empty");
            }
            else
            {
                _head = _head.Next;
                Count--;
                return;
            }
        }

        public void RemoveLast()
        {
            if (IsEmpty)
            {
                throw new NullReferenceException("List is empty");
            }
            else
            {
                var current = _head;
                Node<T> preLast = null;

                while(current.Next != null)
                {
                    preLast = current;
                    current = current.Next;
                }

                preLast.Next = null;
                _tail = preLast;
                Count--;
            }
        }

        public void Clear()
        {
            InitiateList();
        }

        private void InitiateList()
        {
            _head = null;
            _tail = null;
            Count = 0;
        }

        public IEnumerator GetEnumerator()
        {
            var current = _head;

            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }
    }
}
