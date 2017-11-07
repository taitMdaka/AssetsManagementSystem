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
    public class ListAssets : Base, IListAssets
    {
        public List<AssetsDTO> GetAssets()
        {
            // return db.Provinces.Select(x => new ProvinceDTO { ProvinceId = x.ProvinceId, ProvinceName = x.ProvinceName }).ToList();
            return db.AssetsTables.Select(x => new AssetsDTO
            {
                AssetDescription = x.AssetDescription,
                AssetName = x.AssetName,
                AssetSerialNumber = x.AssetSerialNumber,
                AssetSupplier = x.AssetSupplier,
                AssetTypeID = x.AssetTypeID,
                Brand = x.Brand,
                isAllocated = x.isAllocated
            })
                .ToList();
        }
    }
}