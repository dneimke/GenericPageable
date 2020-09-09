using System.Collections.Generic;
using System.Linq;

namespace GenericPageable.Models
{
    public interface IThing
    {
        int Id { get;  }
        string Name { get; }
    }

    public static class ThingExtensions
    {
        public static IEnumerable<T> FilterBy<T>(this IEnumerable<T> source, PagerSettings settings) where T:IThing
        {
            if (settings.OrderBy.ToLower() == "evens")
                return source.Where(x => x.Id % 2 == 0);
            else if (settings.OrderBy.ToLower() == "odds")
                return source.Where(x => x.Id % 2 == 1);
            else
                return source;
        }
    }
}
