using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DaMyNghe.Models;
namespace DaMyNghe.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View(DBContext.getAllDanhMuc_MauDa());
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

        public PartialViewResult CommonView()
        {
            Model1 db = new Model1();
            var data = db.DanhMucs.ToList();
            ViewBag.DanhMuc = data;
            return PartialView("CommonView");
        }
    }
}