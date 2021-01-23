using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyShop.WebUI.Controllers
{
    //[Authorize(Users = "admin@mywebsite.com")] Add Specific Users as Admins
    [Authorize(Roles ="Admin")] //Specify the type of Role necessary to access that necessary must be created and set in DataBase
    //The other way is to use ClaimTypes specified by Microsoft. Creating a ClaimType with get URL from ClaimType Role and create 
    //with ClaimValue Admin in Database for our User
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}