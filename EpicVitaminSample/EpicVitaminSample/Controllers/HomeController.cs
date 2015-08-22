using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EpicVitaminSample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var order = new EpicVitaminSample.Models.Order();
            return View(order);
        }

        [HttpPost]
        public ActionResult Index(EpicVitaminSample.Models.Order model)
        {
            var svc = new EpicVitamins.OrderService();
            var model = svc.GetOrder(id);

            return View(model);
        }
    }
}