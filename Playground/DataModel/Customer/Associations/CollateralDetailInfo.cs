using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
    public partial class CollateralDetailInfo
    {
        [Association(ThisKey = nameof(CollateralTypeId), OtherKey = nameof(DataModel.Customer.CollateralType.Id))]
        public CollateralType CollateralType { get; set; }
    }
}
