using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
            var x = repoApp.Appointments.Where(x => x.Booked == false).ToList();
            return View(x);
        }
        [HttpGet]
        public IActionResult SignupForm(int id)
        {
            var x = repoApp.Appointments.FirstOrDefault(x => x.BookingId == id);
            var y = repoApp.Appointments.FirstOrDefault(x => x.BookingId == id);
            ViewBag.App = x;
            ViewBag.Datey = y.Date;

            return View();
        }

        [HttpPost]
        public IActionResult SignupForm(Signup signup)
        {
            var appId = signup.AppointmentId;
            var app = repoApp.Appointments.FirstOrDefault(x => x.BookingId == appId);
            if (ModelState.IsValid)
            {
                
                repoApp.UpdateApp(app);
                repoSign.Save(signup);
                return Redirect("/");
            }

            ViewBag.App = app;
            ViewBag.Datey = app.Date;
            return View();
        }

        [HttpGet]
        public IActionResult AllAppointments()
        {
            IQueryable<Signup> signups = repoSign.Signups;
            return View(signups);
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
