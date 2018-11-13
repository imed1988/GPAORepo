using GPAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GPAO.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult ViewAll()
        {
            return View(GetAllUsers());
        }

        IEnumerable<User> GetAllUsers()
        {
            using (GPAOEntities db = new GPAOEntities())
            {

                return db.User.ToList<User>();
            }
        }
    }
}