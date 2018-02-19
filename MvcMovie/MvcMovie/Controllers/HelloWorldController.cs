using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }

        //public string Index()
        //{
        //    return "This is <h1>Hello World Page!</h1>";
        //}

        //public string MainPage()
        //{
        //    return "This is <strong> Main Page </strong>";
        //}
    }
}