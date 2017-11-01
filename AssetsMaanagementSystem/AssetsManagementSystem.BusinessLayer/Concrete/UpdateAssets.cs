using AssetsManagementSystem.BusinessLayer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetsManagementSystem.BusinessLayer.DTO;

namespace AssetsManagementSystem.BusinessLayer.Concrete
{
    public class UpdateAssets : Base, IUpdate

    {
        public void updateassets(AssetsDTO assets)
        {
            var temp = db.AssetsTables.Find(assets.ID);
            db.Entry(temp).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();

        }
    }
}
