using System.Collections.Generic;
using System.Linq;
using GenericPageable.Models;

namespace GenericPageable.Data
{
    public class Person
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
        public List<Person> GetPeople(PagerSettings settings)
        {
            var people = Enumerable.Range(1, TotalCount)
                .Skip(settings.Skip)
                .Take(settings.PageSize)
                .Select(x => new Person(x, $"Pet {x}"))
                .ToList();

            return people;
        }
    }
}
