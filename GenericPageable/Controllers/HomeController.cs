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
            var result = _personRepository.GetPeople(settings);
            return View(result);
        }

        public IActionResult Pets(PagerSettings settings)
        {
            var result = _petsRepository.GetPets(settings);
            return View(result);
        }
    }
}
