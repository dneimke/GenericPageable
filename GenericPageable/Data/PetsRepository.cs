using System.Collections.Generic;
using System.Linq;
using GenericPageable.Models;

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
        public List<Pet> GetPets(PagerSettings settings)
        {
            var pets = Enumerable.Range(1, TotalCount)
                .Skip(settings.Skip)
                .Take(settings.PageSize)
                .Select(x => new Pet(x, $"Pet {x}"))
                .ToList();

            return pets;
        }
    }
}
