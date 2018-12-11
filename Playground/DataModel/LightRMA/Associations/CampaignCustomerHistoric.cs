using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB.Mapping;
using PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer;
using PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.LightRMA
{
    public partial class CampaignCustomerHistoric
    {
        [Association(ThisKey = nameof(ListId) + "," + nameof(SublistId), OtherKey = nameof(CustomerSubList.ListId) + "," + nameof(CustomerSubList.SublistId))]
        public CustomerSubList Campaign { get; set; }

        [Association(ThisKey = nameof(AnswerId), OtherKey = nameof(CustomerListItemAnswer.AnswerId))]
        public CustomerListItemAnswer Answer { get; set; }

        [Association(ThisKey = nameof(UserOfAction), OtherKey = nameof(Organization.User.SystemUserId))]
        public Organization.User User { get; set; }

        [Association(ThisKey = nameof(BranchOfAction), OtherKey = nameof(Organization.Branch.BranchIdMnem))]
        public Organization.Branch Branch { get; set; }
    }
}
