using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Zadanie1._2.Models;
using System.Collections;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace Zadanie1._2.Controllers
{
    public class TestController : Controller
    {
        ShapeContext db;
        public TestController(ShapeContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            SelectList books = new SelectList(db.Organizations, "Id", "Name");
            ViewBag.Books = books;
            ViewData["OrganizationId"] = new SelectList(db.Organizations, "Id", "Name");

            return View();
        }
        [HttpPost]
        public JsonResult GetUser()
        {

            var users = from c in db.Shapes
                        select new
                        {
                            c.Id,
                            c.Name,
                            c.Surname,
                            c.Patronymic,
                            c.DateBirth,
                            c.Number,
                            c.Email,
                            org = c.Organization.Name
                        };

            return Json(users);

        }


        public IActionResult AddUser(string name, string surname, string patronymic, DateTime datebirth, string number, string email, int orgId)
        {

            if (name != null && orgId != 0)
            {



                Shape newuser = new Shape
                {

                    Name = name,
                    Surname = surname,
                    Patronymic = patronymic,
                    DateBirth = datebirth,
                    Number = number,
                    Email = email,
                    OrganizationId = orgId
                };

                db.Add(newuser);

                db.SaveChanges();

                var UserData = from c in db.Shapes
                               where c.Id == newuser.Id
                               select new
                               {
                                   c.Id,
                                   c.Name,
                                   c.Surname,
                                   c.Patronymic,
                                   c.DateBirth,
                                   c.Number,
                                   c.Email,
                                   OrganizationName = c.Organization.Name
                               };

                return Json(UserData);
            }

            return NoContent();
        }

        public IActionResult RemoveUser(int nameid)
        {
            var user = db.Shapes.FirstOrDefault(q => q.Id == nameid);

            if (user != null)
            {
                db.Remove(user);

                db.SaveChanges();
            }

            return NoContent();

        }

        public IActionResult UpdateUser(int nameid, string name, string surname, string patronymic, DateTime datebirth, string number, string email, int orgId)
        {
            var user = db.Shapes.FirstOrDefault(q => q.Id == nameid);

            user.Name = name;
            user.Surname = surname;
            user.Patronymic = patronymic;
            user.DateBirth = datebirth;
            user.Number = number;
            user.Email = email;
            user.OrganizationId = orgId;

            db.Update(user);

            db.SaveChanges();


            return NoContent();

        }

    }
}
