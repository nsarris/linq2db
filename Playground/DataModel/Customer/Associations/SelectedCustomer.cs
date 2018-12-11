using LinqToDB.Mapping;
using PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Organization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
    public partial class SelectedCustomer
    {
        [Association(ThisKey = nameof(IpId), OtherKey = nameof(CustomerCommon.IpId))]
        public CustomerCommon CustomerInfo { get; set; }

        [Association(ThisKey = nameof(IpId), OtherKey = nameof(VipXCustomers.IpId))]
        public List<VipXCustomers> VipGroups { get; set; }

        [Association(ThisKey = nameof(BranchOfAction), OtherKey = nameof(Organization.Branch.BranchIdMnem))]
        public Branch Branch { get; set; }

        [Association(ThisKey = nameof(UserOfAction), OtherKey = nameof(Organization.User.SystemUserId))]
        public User User { get; set; }
    }
}
