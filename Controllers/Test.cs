using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanzhouBeefNoodles.controllers
{
    public class TestController:Controller
    {
        public IActionResult Index()
        {
 
            return Content("hello from test index");
        }

        public String About()
        {
            return "hello from test about";
        }
        public ActionResult Contact()
        {
            return View();
        }
    }
}
