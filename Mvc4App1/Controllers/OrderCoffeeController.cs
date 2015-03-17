using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4App1.Controllers
{
    public class OrderCoffeeController : Controller
    {
        //
        // GET: /OrderCoffee/

        public ActionResult Order()
        {
            return View();
        }

    }
}
