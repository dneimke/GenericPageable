using GenericPageable.Data;
using GenericPageable.Models;
using Microsoft.AspNetCore.Mvc;

namespace GenericPageable.Controllers
{
    public class HomeController : Controller
    {
        private readonly PersonRepository _personRepository;
        private readonly PetsRepository _petsRepository;
        int PAGE_SIZE = 10;

        public HomeController(PersonRepository personRepository, PetsRepository petsRepository)
        {
            _personRepository = personRepository;
            _petsRepository = petsRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult People(int pageIndex = 1)
        {
            var people = _personRepository.GetPeople(pageIndex, PAGE_SIZE);
            var result = new PaginatedList<Person>(people, PersonRepository.TotalCount, pageIndex, PAGE_SIZE, "");
            return View(result);
        }

        public IActionResult Pets(int pageIndex = 1)
        {
            var pets = _petsRepository.GetPets(pageIndex, PAGE_SIZE);
            var result = new PaginatedList<Pet>(pets, PetsRepository.TotalCount, pageIndex, PAGE_SIZE, "");
            return View(result);
        }
    }
}
