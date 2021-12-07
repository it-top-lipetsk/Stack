using System;

namespace StackLib
{
    public class Stack<T>
    {
        private Element<T> _head;

        public Stack()
        {
            _head = null;
        }

        public Stack(T value)
        {
            _head = new Element<T>(value);
        }

        public void Push(T value)
        {
            var temp = new Element<T>(value)
            {
                link = _head
            };
            
            _head = temp;
        }

        public T Pop()
        {
            if (_head == null)
            {
                throw new IndexOutOfRangeException("Пустой стек");
            }
            
            var value = _head.value;

            var temp = _head;
            _head = temp.link;

            return value;
        }
    }
}

