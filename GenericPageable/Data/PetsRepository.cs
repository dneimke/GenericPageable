using System.Collections.Generic;
using System.Linq;

namespace GenericPageable.Data
{
    public class Pet
    {
        public Pet(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int Id { get; }
        public string Name { get; }
    }


    public class PetsRepository
    {
        public static int TotalCount = 100;
        public List<Pet> GetPets(int pageIndex, int pageSize)
        {
            var skip = (pageIndex - 1) * pageSize;

            var pets = Enumerable.Range(1, TotalCount)
                .Skip(skip)
                .Skip(pageIndex)
                .Take(pageSize)
                .Select(x => new Pet(x, $"Pet {x}"))
                .ToList();

            return pets;
        }
    }
}
