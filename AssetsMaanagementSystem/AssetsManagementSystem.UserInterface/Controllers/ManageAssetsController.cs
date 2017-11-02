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
        private IUpdate _IUpdate;


        public ManageAssetsController(IInsertAsset iInsertAsset, IListAssets iListAssets, IUpdate iUpdatAssets)
        {
            _IInsertAsset = iInsertAsset;
            _IListAssets = iListAssets;
            _IUpdate = iUpdatAssets;
        }

        // Get list Assets 
        public ActionResult GetAssets()
        {
            // _IListAssets = new ListAssets();
            var allAssets = _IListAssets.GetAssets();
            return View(allAssets);
        }

        // GET: add assets 
        public ActionResult AddAssest()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAssest(AssetsDTO asset)
        {
            _IInsertAsset.AddAsset(asset);
            //clear my assetsDTO 
            ModelState.Clear();
            return View();
        }

        [HttpGet]
        public ActionResult GetAsset(AssetsDTO GetAsset)
        {
            return View();
        }


        public ActionResult UpdateAssets()
        {
            return View();
        }
        [HttpPost]
        public ActionResult UpdateAssets(AssetsDTO EditAsset)
        {
            try
            {
                _IUpdate.updateassets(EditAsset);
                ModelState.Clear();
                ViewBag.Success = "Good";
                return View("UpdateAssets");
            }
            catch (Exception)
            {

                ViewBag.Error = "Error with Updating";
                return View();
            }


        }

    }
}
