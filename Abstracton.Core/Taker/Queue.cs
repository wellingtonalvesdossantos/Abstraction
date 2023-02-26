namespace Abstraction.Core.Taker
{
    public class Queue<T> : ITaker<T> where T : IEquatable<T>
    {
        private List<T> _list = new List<T>();
        public IReadOnlyList<T> List => _list;

        public void AddToList(T item)
        {
            _list.Add(item);
        }

        public void RemoveFromList(T item)
        {
            _list.RemoveAll((x) => x.Equals(item));
        }

        public T Take(bool throwExceptionIfListIsEmpty = false)
        {
            if (!_list.Any())
                if (throwExceptionIfListIsEmpty)
                    throw new InvalidOperationException();
                else
                    return default;
            var item = _list.First();
            _list.Remove(item);
            return item;
        }
    }
}
