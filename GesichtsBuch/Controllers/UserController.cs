using GesichtsBuch.Models;
using GesichtsBuch.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GesichtsBuch.Controllers
{
    public class UserController : Controller
    {
        UserServices services;
        // GET: UserController
        public ActionResult Index()
        {
            services = new UserServices();
            List<User> ul = services.GetAllUsers();
            return View(ul);
        }

               
    }
}
