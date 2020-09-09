using GenericPageable.Models;
using Microsoft.AspNetCore.Mvc;

namespace GenericPageable.Views.Shared.Components.Pager
{
    public class Pager : ViewComponent
    {
        public IViewComponentResult Invoke(IPageable pageable)
        {
            return View(pageable);
        }
    }
}
