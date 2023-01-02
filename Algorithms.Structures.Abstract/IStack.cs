namespace Algorithms.Structures.Abstract
{
    public interface IStack<T>
    {
        T Pop();
        void Push(T item);

        bool IsEmpty();
    }
}