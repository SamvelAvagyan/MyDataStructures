using System;

namespace MyDataStructures
{
    class StackOnArray<T>
    {
        private T[] _arr;
        private int _currentIndex;
        public int Count => _arr.Length;

        public StackOnArray(int size)
        {
            _arr = new T[size];
            _currentIndex = -1;
        }

        public void Push(T value)
        {
            _currentIndex++;
            _arr[_currentIndex] = value;
        }

        public T Pop()
        {
            if(_currentIndex == -1)
            {
                throw new Exception("Stack is empty");
            }

            var item = _arr[_currentIndex];
            _arr[_currentIndex] = default(T);
            _currentIndex--;

            return item;
        }

        public T Peek()
        {
            if (_currentIndex == -1)
            {
                throw new Exception("Stack is empty");
            }

            return _arr[_currentIndex];
        }
    }
}
