using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB.Mapping;
using PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer;
using PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.LightRMA
{
    public partial class CampaignCustomer
    {
        [Association(ThisKey = nameof(IpId), OtherKey = nameof(DataModel.Customer.Customer.CrsId))]
        public Customer.Customer Customer { get; set; }

        //[Association(ThisKey = nameof(Status1TypeId) + "," + nameof(Status1ClassType), OtherKey = nameof(Classification.TypeId) + "," + nameof(Classification.ClassType))]
        //public Classification Status1;

        //[Association(ThisKey = nameof(Status2TypeId) + "," + nameof(Status2ClassType), OtherKey = nameof(Classification.TypeId) + "," + nameof(Classification.ClassType))]
        //public Classification Status2;

        [Association(ThisKey = nameof(ListId) + "," + nameof(SublistId), OtherKey = nameof(CustomerSubList.ListId) + "," + nameof(CustomerSubList.SublistId))]
        public CustomerSubList Campaign { get; set; }
                       
        [Association(ThisKey = nameof(AnswerId), OtherKey = nameof(CustomerListItemAnswer.AnswerId))]
        public CustomerListItemAnswer Answer { get; set; }

        [Association(ThisKey = nameof(UserOfAction), OtherKey = nameof(Organization.User.SystemUserId))]
        public Organization.User LastUpdateUser { get; set; }
    }
}
