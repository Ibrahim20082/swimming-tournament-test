using System.Diagnostics;
using System;
using Microsoft.AspNetCore.Mvc;
using WebApplication1_Book_.Models;
using PartyInvites.Models;
using System.Linq;

namespace WebApplication1_Book_.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 && hour >= 4 ? "Good Morning" : hour < 18 && hour >= 12 ? "Good Afternoon" : hour < 21 && hour >= 12 ? "Good Evening" : "Good Evening";
            ViewBag.GreetingColor = hour < 12 && hour >= 4 ? "orange" : hour < 18 && hour >= 12 ? "limegreen" : hour < 21 && hour >= 18 ? "darkred" : "darkmagenta";
            return View("MyView");
        }
        [HttpGet]
        public ViewResult RegistrationForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RegistrationForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(guestResponse);
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }

        }
        public ViewResult ListResponses()
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }
    }
}