using AssetsManagementSystem.BusinessLayer.DTO;
using AssetsManagementSystem.BusinessLayer.Interface;
using AssetsManagementSystem.DataLayer;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagementSystem.BusinessLayer.Concrete
{

    public class assets
    {
        public List<AssetsDTO> getassets()
        {

            var temp = new List<AssetsDTO>();

            using (var db = new AssetManagementSystemContext())
            {


                //   return db.UserProfiles.Where(x => x.UserProfileId == ID).Select(user => new UserProfileDTO

                {

                    return temp = db.AssetsTables.Where(x => x.ID != 0).Select(x => new AssetsDTO
                    {
                        ID = x.ID,
                        AssetDescription = x.AssetDescription,
                        AssetName = x.AssetName,
                        AssetSerialNumber = x.AssetSerialNumber,
                        AssetSupplier = x.AssetSupplier,
                        AssetTypeID = x.AssetTypeID,
                        Brand = x.Brand,
                        isAllocated = x.isAllocated
                    }).ToList();

                }
            }
            return temp;
        }
    }
}


