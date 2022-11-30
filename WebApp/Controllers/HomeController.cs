﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using System.Web.UI.WebControls;
using WebApp.DataBase;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        usersEntities db = new usersEntities();

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
                var users = db.Users;

                if(users.Any())
               
                return RedirectToAction("Index");
            }
            return View();
        }
        
    }
}