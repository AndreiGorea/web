using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;
using eUserControl.Web.Models;
using eUserControl.BusinessLogic;
using eUserControl.BusinessLogic.Interfaces;
using eUserControl.Domain.Entities.User;


namespace eUserControl.Web.Controllers
{
     public class LoginController : Controller
     {
          private readonly ISession _session;

          public LoginController()
          {
               var bl = new MyBusinessLogic();
               _session = bl.GetSessionBl();
          }
          // GET: Login
          public ActionResult Index()
          {
               return View();
          }

          [HttpPost]
          [ValidateAntiForgeryToken]
          public ActionResult Index(UserLogin login)
          {
               if (ModelState.IsValid)
               {
                    ULoginData data = new ULoginData
                    {
                         Credential = login.Credential,
                         Password = login.Password,
                         LoginIp = Request.UserHostAddress,
                         LoginDateTime = DateTime.Now
                    };


                    var userLogin = _session.UserLogin(data);
                    if (userLogin.Status)
                    {
                         //add cookie
                         return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                         ModelState.AddModelError("", userLogin.StatusMsg);
                         return View();
                    }
               }

               return View();
          }
     }
}