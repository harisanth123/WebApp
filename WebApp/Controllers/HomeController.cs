using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using System.Web.UI.WebControls;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private Database.usersEntities db = new Database.usersEntities();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
           return View();
        }
        [HttpPost]
        public ActionResult LoginProcess(Login_Model data)
        {
            if(ModelState.IsValid)
            {
                if (db.Users.Any(k => k.User_Name == data.Username && k.User_PassWord == data.Password))
                    {
                    return RedirectToAction("Index");
                    }
            }
            return RedirectToAction("Login");
        }
        [HttpPost]
        public JsonResult GetallDetails()
        {
            List<User_DetailsModel> userdata = new List<User_DetailsModel>();
            var dat = db.UserDetails.ToList();
            userdata = dat.Select(k => new User_DetailsModel
            {
                name = k.User_Name,
                dob = k.User_DateOfBirth,
                Job = k.User_Job,
                place = k.User_Place
            }).ToList();
            return Json(userdata, JsonRequestBehavior.DenyGet);
        }
    }
}