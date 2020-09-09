using Microsoft.AspNetCore.Mvc;

namespace GenericPageable.Views.Shared.Components.Filter
{
    public class Filter : ViewComponent
    {
        public IViewComponentResult Invoke(string action)
        {
            return View("Default", action);
        }
    }
}
