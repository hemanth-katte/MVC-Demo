using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {   

            return View();
        }

        public IActionResult HelloWorld()
        {
            return View();
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            return View("Index");
        }
    }
}
