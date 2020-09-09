using GenericPageable.Data;
using GenericPageable.Models;
using Microsoft.AspNetCore.Mvc;

namespace GenericPageable.Controllers
{
    public class HomeController : Controller
    {
        private readonly PersonRepository _personRepository;
        private readonly PetsRepository _petsRepository;
        

        public HomeController(PersonRepository personRepository, PetsRepository petsRepository)
        {
            _personRepository = personRepository;
            _petsRepository = petsRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult People(PagerSettings settings)
        {
            var people = _personRepository.GetPeople(settings);
            var result = new PaginatedList<Person>(people, PersonRepository.TotalCount, settings);
            return View(result);
        }

        public IActionResult Pets(PagerSettings settings)
        {
            var pets = _petsRepository.GetPets(settings);
            var result = new PaginatedList<Pet>(pets, PetsRepository.TotalCount, settings);
            return View(result);
        }
    }
}
