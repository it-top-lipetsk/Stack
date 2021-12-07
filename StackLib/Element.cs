namespace StackLib
{
    public class Element<T>
    {
        public T value;
        public Element<T> link;

        public Element(T value)
        {
            this.value = value;
            link = null;
        }
    }
}