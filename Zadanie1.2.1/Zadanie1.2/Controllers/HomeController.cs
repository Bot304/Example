using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Zadanie1._2.Models;

namespace Zadanie1._2.Controllers
{
    public class HomeController : Controller
    {
        ShapeContext db;
        public HomeController(ShapeContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Shapes.ToList());
        }

        public IActionResult Main()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Success(string name)
        {
            ViewBag.Name = name;
            return View();
        }

        [HttpGet]
        public IActionResult Insert(int? id)
        {
            return View();
            //ViewBag.Id = id;
        }

        [HttpPost]
        public IActionResult Insert(Shape shape)
        {
            db.Shapes.Add(shape);
            // сохраняем в бд все изменения
            db.SaveChanges();
            //return "Спасибо, " + shape.Name + ", за покупку!";
            return RedirectToAction("Success", new { name=shape.Name });  // разобраться
        }
    }
}
