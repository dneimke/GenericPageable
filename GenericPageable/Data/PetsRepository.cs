using System.Linq;
using GenericPageable.Models;

namespace GenericPageable.Data
{
    public class Pet : IThing
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
        public PaginatedList<Pet> GetPets(PagerSettings settings)
        {
            var list = Enumerable.Range(1, 100)
                .Select(x => new Pet(x, $"Pet {x}"))
                .FilterBy(settings)
                .ToList();

            var pets = list.Skip(settings.Skip)
                .Take(settings.PageSize)
                .ToList();

            return new PaginatedList<Pet>(pets, list.Count, settings);
        }
    }
}
