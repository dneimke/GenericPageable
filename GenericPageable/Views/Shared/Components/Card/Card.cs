using GenericPageable.Models;
using Microsoft.AspNetCore.Mvc;

namespace GenericPageable.Views.Shared.Components.Card
{
    public class Card : ViewComponent
    {
        public IViewComponentResult Invoke(IThing thing)
        {
            return View(thing);
        }
    }
}
