namespace Abstraction.Core.Extensions
{
    public static class ListExtensions
    {
        public static string JoinIntoString<T>(this IReadOnlyCollection<T> list, string separator = ";")
        {
            if(list == null || !list.Any()) return string.Empty;
            return string.Join(separator, list.Select(x => Convert.ToString(x)));
        }
    }
}
