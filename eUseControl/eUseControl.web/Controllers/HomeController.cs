using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eUserControl.Web.Controllers
{
     public class HomeController : Controller
     {
          // GET: Home
          public ActionResult Index()
          {
               return View();
          }
          public ActionResult Blog()
          {
               return View();
          }
          public ActionResult BLog_details()
          {
               return View();
          }
          public ActionResult Check_out()
          {
               return View();
          }
          public ActionResult Contact()
          {
               return View();
          }
          public ActionResult Faq()
          {
               return View();
          }
          public ActionResult Shop()
          {
               return View();
          }
          public ActionResult Shopping_cart()
          {
               return View();
          }
     }
}