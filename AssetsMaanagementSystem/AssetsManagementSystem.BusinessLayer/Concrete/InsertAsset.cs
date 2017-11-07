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
    public class InsertAsset : Base, IInsertAsset
    {
        public void AddAsset(AssetsDTO asset)
        {
            //using disposes an intance after a scope 
            //AssetManagementSystemContext db = new AssetManagementSystemContext();
            AssetsTable assetTable = new AssetsTable
            {
                AssetName = asset.AssetName,
                AssetDescription = asset.AssetDescription,
                Brand = asset.Brand,
                AssetSerialNumber = asset.AssetSerialNumber,
                AssetTypeID = asset.AssetTypeID,
                isAllocated = asset.isAllocated,
                AssetSupplier = asset.AssetSupplier,
                isDeleted = false
            };
            db.AssetsTables.Add(assetTable);
            db.SaveChanges();
        }
    }
}
