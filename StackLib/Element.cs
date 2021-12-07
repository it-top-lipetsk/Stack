namespace StackLib
{
    public class Element
    {
        public int value;
        public Element next;
        public Element prev;

        public Element()
        {
            Init(0, null, null);
        }

        public Element(int value)
        {
            Init(value, null, null);
        }

        public Element(int value, Element prev, Element next)
        {
            Init(value, prev, next);
        }

        public Element(Element element)
        {
            value = element.value;
            prev = element.prev;
            next = element.next;
        }

        private void Init(int value, Element prev, Element next)
        {
            this.value = value;
            this.next = next;
            this.prev = prev;
        }
    }
}