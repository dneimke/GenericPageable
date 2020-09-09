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
        public static IEnumerable<IThing> FilterBy(this IEnumerable<IThing> source, PagerSettings settings)
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
