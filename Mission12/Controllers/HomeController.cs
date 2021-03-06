using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Mission12.Models;

namespace Mission12.Controllers
{
    public class HomeController : Controller
    {
        private ISignupRepository repoSign;
        private IAppointmentRepository repoApp;
        public HomeController(ISignupRepository temp, IAppointmentRepository temp2)
        {
            repoSign = temp;
            repoApp = temp2;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Timeslots()
        {
            var x = repoApp.Appointments.ToList();
            return View(x);
        }
        [HttpGet]
        public IActionResult SignupForm(string id)
        {
            var ids = id.Replace("%2F", "/");
            DateTime y = DateTime.Parse(ids);
            ViewBag.Datey = y;

            return View();
        }

        [HttpPost]
        public IActionResult SignupForm(Signup signup)
        {
            
            if (ModelState.IsValid)
            {
                    repoSign.Save(signup);
                    return RedirectToAction("Index");
            }

           
            ViewBag.Datey = signup.Appointment.Date;
            return View();
        }

        [HttpGet]
        public IActionResult AllAppointments()
        {
            var extraData = repoSign.GetAll();
            return View(extraData);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var r = repoSign.Signups.FirstOrDefault(x => x.AppointmentId == id);
            
            var y = repoApp.Appointments.FirstOrDefault(x => x.BookingId == r.AppointmentId);
            ViewBag.App = y;
            ViewBag.Datey = y.Date;
            return View(r);
        }

        [HttpPost]
        public IActionResult Edit(Signup signup)
        {
            if (ModelState.IsValid)
            {
                repoSign.Edit(signup);
                return RedirectToAction("AllAppointments");
            }
            else
            {
                return View(signup);
            }
            
            
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var x = repoSign.Signups.FirstOrDefault(x => x.AppointmentId == id);
            var y = repoApp.Appointments.FirstOrDefault(r => r.BookingId == x.AppointmentId);
            repoSign.Delete(x);
            repoApp.DeleteApp(y);
            return RedirectToAction("AllAppointments");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
