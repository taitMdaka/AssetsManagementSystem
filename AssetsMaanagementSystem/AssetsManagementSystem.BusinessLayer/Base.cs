using AssetsManagementSystem.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetsManagementSystem.BusinessLayer
{
    public abstract class Base
    {
        public AssetManagementSystemContext db = new AssetManagementSystemContext();
    }
}
