using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagementSystem.BusinessLayer.DTO
{
    public class AssetsDTO
    {
        public int ID { get; set; }
        public string AssetName { get; set; }
        public string AssetDescription { get; set; }
        public int AssetSerialNumber { get; set; }
        public int? AssetTypeID { get; set; }
        public string Brand { get; set; }
        public string AssetSupplier { get; set; }
        public bool? isAllocated { get; set; }
        public bool? isDeleted { get; set; }
    }
}
