//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AssetsManagementSystem.DataLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class AssetsTable
    {
        public int ID { get; set; }
        public string AssetName { get; set; }
        public string AssetDescription { get; set; }
        public int AssetSerialNumber { get; set; }
        public Nullable<int> AssetTypeID { get; set; }
        public string Brand { get; set; }
        public string AssetSupplier { get; set; }
        public Nullable<bool> isAllocated { get; set; }
    
        public virtual TypeofAssetTable TypeofAssetTable { get; set; }
    }
}
