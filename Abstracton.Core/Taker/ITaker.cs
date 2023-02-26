namespace Abstraction.Core.Taker
{
    public interface ITaker<T>
    {
        public IReadOnlyList<T> List { get; }

        void AddToList(T item);
        void RemoveFromList(T item);
        T Take(bool throwExceptionIfListIsEmpty = false);
    }
}
