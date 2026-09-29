using System.Collections;

namespace SoundCore.EstructurasPropias
{
    public class SimpleLinkedList<T> : IEnumerable<T>
    {
        public Node<T>? Head { get; private set; }
        public int Count { get; private set; }

        public bool IsEmpty => Head == null;

        public void AddAtTheEnd(T valor)
        {
            var nuevoNodo = new Node<T>(valor);
            if (IsEmpty)
            {
                Head = nuevoNodo;
            }
            else
            {
                var actual = Head!;
                while (actual.Next != null)
                {
                    actual = actual.Next;
                }
                actual.Next = nuevoNodo;
            }
            Count++;
        }

        public void PlayNext(T valor)
        {
            var newNode = new Node<T>(valor);
            if (IsEmpty)
            {
                Head = newNode;
            }
            else
            {
                newNode.Next = Head!.Next;
                Head.Next = newNode;
            }
            Count++;
        }

        public T SkipTrack()
        {
            if (IsEmpty)
                throw new InvalidOperationException("La cola de reproducción está vacía.");

            T value = Head!.Value;
            Head = Head.Next;
            Count--;
            return value;
        }

  
        public void Invertir()
        {
            Node<T>? previous = null;
            Node<T>? actual = Head;
            Node<T>? next;

            while (actual != null)
            {
                next = actual.Next; 
                actual.Next = previous;    
                previous = actual;              
                actual = next;           
            }

            Head = previous;
        }

        public void InsertSorted(T value, Comparison<T> comparator)
        {
            var New = new Node<T>(value);

            if (IsEmpty || comparator(value, Head!.Value) < 0)
            {
                New.Next = Head;
                Head = New;
                Count++;
                return;
            }

            var actual = Head;
            while (actual.Next != null && comparator(value, actual.Next.Value) >= 0)
            {
                actual = actual.Next;
            }

            New.Next = actual.Next;
            actual.Next = New;
            Count++;
        }

        public void DeleteDupes(Func<T, T, bool> areEqual)
        {
            var actual = Head;

            while (actual != null)
            {
                var runner = actual;
                while (runner.Next != null)
                {
                    if (areEqual(actual.Value, runner.Next.Value))
                    {
                        runner.Next = runner.Next.Next;
                        Count--;
                    }
                    else
                    {
                        runner = runner.Next;
                    }
                }
                actual = actual.Next;
            }
        }

        public void Clear()
        {
            Head = null;
            Count = 0;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var actual = Head;
            while (actual != null)
            {
                yield return actual.Value;
                actual = actual.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
