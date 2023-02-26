using Abstraction.Core.Taker;

namespace Abstraction.Core.Extensions
{
    public static class TakerExtensions
    {
        public static void AddRange<T>(this ITaker<T> taker, params T[] values)
        {
            foreach (var item in values)
                taker.AddToList(item);
        }
    }
}
