using System.Net;

namespace StackLib
{
    public class Stack
    {
        private Element _element;

        public Stack()
        {
            _element = new Element();
        }

        public Stack(int value)
        {
            _element = new Element(value);
        }

        public void Push(int value)
        {
            var temp = new Element(value);

            _element.next = temp;
            temp.prev = _element;
        }

        public int Pop()
        {
            var current = new Element(_element);

            do
            {
                current = current.next;
            } while (current.next != null);

            return current.value;
        }
    }
}

