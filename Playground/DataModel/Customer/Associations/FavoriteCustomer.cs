using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
    public partial class FavouriteCustomer
    {
        [Association(ThisKey = nameof(IpId), OtherKey = nameof(CustomerCommon.IpId))]
        public CustomerCommon CustomerInfo { get; set; }
    }
}
