using AssetsManagementSystem.BusinessLayer.Concrete;
using AssetsManagementSystem.BusinessLayer.DTO;
using AssetsManagementSystem.BusinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AssetsManagementSystem.UserInterface.Controllers
{
    public class ManageAssetsController : Controller
    {
        //creating a private field
        private IInsertAsset _IInsertAsset;
        private IListAssets _IListAssets;


        public ManageAssetsController(IInsertAsset iInsertAsset, IListAssets iListAssets)
        {
            _IInsertAsset = iInsertAsset;
            _IListAssets = iListAssets;

        }

        // Get list Assets 
        public ActionResult Liasassets()
        {
            return View();
        }

        // GET: add assets 
        public ActionResult AddAssest()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAssest(AssetsDTO asset)
        {
            //calling mymethod from BL 
            // InsertAsset addassets = new InsertAsset();
            //addassets.AddAsset(asset);
            _IInsertAsset.AddAsset(asset);
            //clear my assetsDTO 
            ModelState.Clear();
            return View();
        }
        [HttpGet]
        public ActionResult Liasassets(AssetsDTO liasassets)
        {
            //calling mymethod from BL 
            // InsertAsset addassets = new InsertAsset();
            //addassets.AddAsset(asset);
            _IListAssets.GetAssets();
            //_IInsertAsset.AddAsset(asset);
            //clear my assetsDTO 

            return View();

        }
    }
}
