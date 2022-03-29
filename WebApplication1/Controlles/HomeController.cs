using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Models;

namespace WebApplication1.Controlles
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello World";
        }

        public ViewResult Index2()
        {
            return View();
        }
        public IActionResult Index3()
        {
            List<Person> persons = new List<Person> {
                new Person{Id=1, Name="Cavid", CityId=1, Surname="Mahsumov"},
                new Person{Id=1, Name="John", CityId=1, Surname="Jognlu"},
                new Person{Id=1, Name="Cavid", CityId=1, Surname="Mahsumov"}

            };

            List<string> cities = new List<string> { "Baku", "Istanbul" };

            var model = new PersonListViewModel { Cities = cities, Persons = persons };
            return View(model);
        }

        public RedirectResult Index6()
        {
            return Redirect("/home/index3");
        }
        public RedirectToRouteResult Index7()
        {
           return RedirectToRoute("Default", new { action = "Index3" });
        }
    }
}
