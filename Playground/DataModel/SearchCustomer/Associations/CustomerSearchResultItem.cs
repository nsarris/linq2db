using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;
using DataModel = PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.SearchCustomer
{
    public partial class CustomerSearchResultItem
    {
        [Association(ThisKey = nameof(IpId), OtherKey = nameof(DataModel.Customer.Customer.CrsId))]
        public DataModel.Customer.Customer Customer { get; set; }
    }
}
