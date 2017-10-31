using AssetsManagementSystem.BusinessLayer.Concrete;
using AssetsManagementSystem.BusinessLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssetsManagementSystem.UserInterface.Controllers
{
    public class HomeController : Controller
    {

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult InsertAsset(AssetsDTO asset)
        {

            return View();
        }


    }
}