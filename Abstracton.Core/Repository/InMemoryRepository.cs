namespace Abstraction.Core.Repository
{
    public class InMemoryRepository<T> : IRepository<T> where T : class
    {
        private List<T> _list = new List<T>();

        public void Add(T entity)
        {
            _list.Add(entity);
        }

        public long Count()
        {
            return _list.Count;
        }

        public IReadOnlyList<T> GetAll()
        {
            return _list;
        }

        public void Delete(T entity)
        {
            _list.RemoveAll((x) => x.Equals(entity));
        }
    }
}
