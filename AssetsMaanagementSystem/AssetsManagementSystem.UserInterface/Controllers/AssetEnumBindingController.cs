using AssetsManagementSystem.UserInterface.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssetsManagementSystem.UserInterface.Controllers
{
    public class AssetEnumBindingController : Controller
    {
        // GET: BindData
        public ActionResult Index()
        {
            var AssetEnumData = from AssetTypeEnum e in Enum.GetValues(typeof(AssetTypeEnum))
                                select new
                                {
                                    AssetTypeID = (int)e,
                                    AssetType = e.ToString()
                                };
            {
                ViewBag.EnumList = new SelectList(AssetEnumData, "AssetTypeID", "AssetType");
                return View();
            }
        }
    }
}



