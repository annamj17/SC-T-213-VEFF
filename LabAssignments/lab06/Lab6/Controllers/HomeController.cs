using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab6.Models.InputModels;
using Lab6.Models;

namespace Lab6.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(FakeDatabase.Students);
        }

        public IActionResult GetText()
        {
            return Json("Hello world");
        }

        public IActionResult GetSecretStudent()
        {
            var student = new Student { Age = 80, Name = "Bugs Bunny"};
            
            return Json(student);
        }

        [HttpPost]
        public IActionResult Add(StudentInputModel student)
        {
            var newStudent = new Student
            {
                Age = student.Age,
                Name = student.Name
            };
            FakeDatabase.Students.Add(newStudent);

            return Ok(newStudent);
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
