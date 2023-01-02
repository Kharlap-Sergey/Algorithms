using Algorithms.Structures.Abstract;

namespace Algorithms.Structures.Concreet.Stack
{
    public class LinkedListStack<T> : IStack<T>
    {
        private LinkedEntity<T>? _first = null;
        public bool IsEmpty()
        {
            return _first == null;
        }

        public T Pop()
        {
            if (IsEmpty()) throw new Exception();

            var temp = _first!;
            _first = temp.Next;
            return temp.Item;
        }

        public void Push(T item)
        {
            _first = new LinkedEntity<T> { Item = item, Next = _first };
        }

        private class LinkedEntity<T>
        {
            public T Item { get; set; }
            public LinkedEntity<T>? Next { get; set; } = null;
        }
    }
}
