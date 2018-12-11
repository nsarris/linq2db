using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;
using PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer;


namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{	
    public partial class CustomerCommon
    {
        [Association(ThisKey = nameof(IpId), OtherKey = nameof(CustomerLegalEntity.IpId))]
        public CustomerLegalEntity LegalEntity { get; set; }

        [Association(ThisKey = nameof(IpId), OtherKey = nameof(CustomerPhysicalEntity.IpId))]
        public CustomerPhysicalEntity PhysicalEntity { get; set; }

        [Association(ThisKey = nameof(CustomerBranchId), OtherKey = nameof(Organization.Branch.IpId))]
        public Organization.Branch Branch { get; set; }
    }
}
