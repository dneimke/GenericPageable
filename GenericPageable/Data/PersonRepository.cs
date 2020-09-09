using System.Linq;
using GenericPageable.Models;

namespace GenericPageable.Data
{
    public class Person : IThing
    {
        public Person(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }
    }


    public class PersonRepository
    {
        public static int TotalCount = 100;
        public PaginatedList<IThing> GetPeople(PagerSettings settings)
        {
            var list = Enumerable.Range(1, TotalCount)
                .Select(x => new Person(x, $"Person {x}"))
                .FilterBy(settings)
                .ToList();

            var people = list.Skip(settings.Skip)
                .Take(settings.PageSize)
                .ToList();

            return new PaginatedList<IThing>(people, list.Count, settings);
        }
    }
}
