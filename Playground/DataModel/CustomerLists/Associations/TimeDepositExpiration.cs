using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{	
	
	[Table(Name = "LHXDEPPF", Schema = "XCRS")]
	public partial class TimeDepositExpiration
	{
        [Association(ThisKey = nameof(IpId), OtherKey = nameof(DataModel.Customer.Customer.CrsId))]
        public Customer.Customer Customer { get; set; }

        [Association(ThisKey = nameof(Status1TypeId) + "," + nameof(Status1ClassType), OtherKey = nameof(Classification.TypeId) + "," + nameof(Classification.ClassType))]
        public Classification Status1 { get; set; }

        [Association(ThisKey = nameof(Status2TypeId) + "," + nameof(Status2ClassType), OtherKey = nameof(Classification.TypeId) + "," + nameof(Classification.ClassType))]
        public Classification Status2 { get; set; }

        [Association(ThisKey = nameof(Status1TypeId) + "," + nameof(Status1ClassType), OtherKey = nameof(ClassificationExtension.TypeId) + "," + nameof(ClassificationExtension.ClassType))]
        public ClassificationExtension TerminalStatus { get; set; }
        [Association(ThisKey = nameof(UserOfAction), OtherKey = nameof(Organization.User.SystemUserId))]
        public Organization.User LastUpdateUser { get; set; }
    }
}
