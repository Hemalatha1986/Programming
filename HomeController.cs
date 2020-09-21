using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCproject
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            int hour = DateTime.Now.Hour;

            ViewBag.Greeting =
            hour < 12
            ? "Good Morning. Time is" + DateTime.Now.ToShortTimeString()
            : "Good Afternoon. Time is " + DateTime.Now.ToShortTimeString();

            return View();
            
        }


    }

    
}
