using LinqToDB.Mapping;
using PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{	
	public partial class FatcaExpirationHistoric
    {      

        [Association(ThisKey = nameof(Status1TypeId) + "," + nameof(Status1ClassType), OtherKey = nameof(Classification.TypeId) + "," + nameof(Classification.ClassType))]
        public Classification Status1 { get; set; }

        [Association(ThisKey = nameof(Status2TypeId) + "," + nameof(Status2ClassType), OtherKey = nameof(Classification.TypeId) + "," + nameof(Classification.ClassType))]
        public Classification Status2 { get; set; }

        [Association(ThisKey = nameof(UserOfAction), OtherKey = nameof(Organization.User.SystemUserId))]
        public Organization.User User { get; set; }

        [Association(ThisKey = nameof(BranchOfAction), OtherKey = nameof(DataModel.Organization.Branch.BranchIdMnem))]
        public DataModel.Organization.Branch Branch { get; set; }
    }
}
