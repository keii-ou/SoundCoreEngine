namespace SoundCore.EstructurasPropias
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T>? Next { get; set; }

        public Node(T valor)
        {
            Value = valor;
            Next = null;
        }
    }
}
