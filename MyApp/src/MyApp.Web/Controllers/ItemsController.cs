using Microsoft.AspNetCore.Mvc;
using MyApp.Web.Models;

namespace MyApp.Web.Controllers
{
    public class ItemsController : Controller
    {
        // GET: ItemsController
        [HttpGet]
        public IActionResult Overview()
        {
            var item = new Item() {Name = "Simple Item"};
            return View(item);
        }

        [HttpGet]
        public IActionResult Edit(int id){
            return Content($"Informed ID: {id}");
        }
    }
}
