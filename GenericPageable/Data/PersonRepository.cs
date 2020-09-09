using System.Collections.Generic;
using System.Linq;

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
        public List<Person> GetPeople(int pageIndex, int pageSize)
        {
            var people = Enumerable.Range(1, TotalCount)
                .Skip(pageIndex)
                .Take(pageSize)
                .Select(x => new Person(x, $"Pet {x}"))
                .ToList();

            return people;
        }
    }
}
