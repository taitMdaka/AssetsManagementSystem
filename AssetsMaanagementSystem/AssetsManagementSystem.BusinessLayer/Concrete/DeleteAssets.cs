using AssetsManagementSystem.BusinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetsManagementSystem.BusinessLayer.DTO;
using AssetsManagementSystem.DataLayer;

namespace AssetsManagementSystem.BusinessLayer.Concrete
{
    public class DeleteAssets : Base, IDeleteAssets
    {
        public void deleteasset(AssetsDTO asset)
        {
            //1. Get student from DB

            var assetToDelete = db.AssetsTables.Find(asset.ID);
            db.AssetsTables.Remove(assetToDelete);
            db.SaveChanges();


        }
    }
}
