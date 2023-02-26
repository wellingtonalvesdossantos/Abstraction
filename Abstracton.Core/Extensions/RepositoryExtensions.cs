using Abstraction.Core.Repository;

namespace Abstraction.Core.Extensions
{
    public static class RepositoryExtensions
    {
        public static void AddRange<T>(this IRepository<T> repository, params T[] values) where T : class
        {
            foreach (var item in values)
                repository.Add(item);
        }
    }
}
