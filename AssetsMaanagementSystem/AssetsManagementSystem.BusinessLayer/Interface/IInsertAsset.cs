using AssetsManagementSystem.BusinessLayer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagementSystem.BusinessLayer.Interface
{
    public interface IInsertAsset
    {
        void AddAsset(AssetsDTO asset);
    }
}
