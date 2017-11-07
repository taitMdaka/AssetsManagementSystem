using AssetsManagementSystem.BusinessLayer.DTO;
using AssetsManagementSystem.BusinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagementSystem.BusinessLayer.Concrete
{
    public class AssetsListTypes : Base, IListType
    {
        public List<AssetsTypeDTO> GetAssets()
        {
            return db.TypeofAssetTables.Select(x => new AssetsTypeDTO
            {
                AssetType = x.AssetType,
                AssetTypeID = x.AssetTypeID
            })
            .ToList();
        }
    }
}