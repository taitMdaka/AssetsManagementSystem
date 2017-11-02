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
    public class UpdateAssets : Base, IUpdate

    {
        public void updateassets(AssetsDTO asset)
        {

            try
            {
                if (db.AssetsTables.Any(a => a.ID == asset.ID))
                {

                    AssetsTable assetTable = new AssetsTable
                    {
                        ID = asset.ID,
                        AssetName = asset.AssetName,
                        AssetDescription = asset.AssetDescription,
                        Brand = asset.Brand,
                        AssetSerialNumber = asset.AssetSerialNumber,
                        AssetTypeID = asset.AssetTypeID,
                        isAllocated = asset.isAllocated,
                        AssetSupplier = asset.AssetSupplier,
                        isDeleted = asset.isDeleted

                    };

                    db.Entry(assetTable).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
