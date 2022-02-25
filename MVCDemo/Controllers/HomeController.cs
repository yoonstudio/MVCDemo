using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        Product SampleProduct = new Product
        {
            ProductID = 1,
            Name = "책상",
            Description = "사무용",
            Category = "가구",
            Priced = 100000
        };

        public ActionResult Index()
        {
            ViewBag.Message = "Razor~";
            return View(SampleProduct);
        }

        public ActionResult ProductInfo()
        {
            return View(SampleProduct);
        }

        public ActionResult SampleAction()
        {
            ViewBag.OrderCount = 3;
            ViewBag.ProductCount = 1;
            ViewBag.Discount = true;
            ViewBag.ShipPrice = false;

            return View(SampleProduct);
        }

        public ActionResult ArraySampleAction()
        {
            Product[] array =
                {
                new Product {Name = "점퍼", Priced = 60000},
                new Product {Name = "농구공", Priced = 30000},
                new Product {Name = "TV", Priced = 1000000}
                };

            return View(array);
        }

        public ActionResult AutoProperty()
        {
            Product product = new Product();

            product.Name = "pd_01";

            string productName = product.Name;

            return View("Result", (object)string.Format($"상품명: {productName}"));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}