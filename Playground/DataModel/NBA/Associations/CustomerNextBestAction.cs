using LinqToDB.Mapping;
using DataModel = PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel;
using PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.NBA
{
    public partial class CustomerNextBestAction
    {
        [Association(ThisKey = nameof(Id), OtherKey = nameof(CustomerNextBestActionHistory.Id))]
        public List<CustomerNextBestActionHistory> HistoricNBAs { get; set; }

        [Association(CanBeNull = true, ExpressionPredicate = nameof(NBAPredicate))]
        public CustomerSubList NextBestAction { get; set; }

        public static Expression<Func<CustomerNextBestAction, CustomerSubList, bool>> NBAPredicate { get; } = (x, y) => y.SublistId == x.NbaId && y.ListId == ((int)CustomerListTypeEnum.NBA).ToString().PadLeft(3, '0');

        [Association(ThisKey = nameof(UserOfAction), OtherKey = nameof(Organization.User.SystemUserId))]
        public Organization.User LastUpdateUser { get; set; }


        [Association(ThisKey = nameof(IpId), OtherKey = nameof(DataModel.Customer.Customer.CrsId))]
        public DataModel.Customer.Customer Customer { get; set; }

        [Association(ThisKey = nameof(Lvl2Answer)  + "," + nameof(Lvl3Answer), OtherKey = nameof(CustomerListItemAnswer.ParentAnswerId) + "," + nameof(CustomerListItemAnswer.AnswerId))]
        public CustomerListItemAnswer Answer { get; set; }

        [Association(ThisKey = nameof(Lvl1Answer), OtherKey = nameof(CustomerListItemAnswer.AnswerId))]
        public CustomerListItemAnswer AnswerLevel1 { get; set; }

        [Association(ThisKey = nameof(Lvl2Answer), OtherKey = nameof(CustomerListItemAnswer.AnswerId))]
        public CustomerListItemAnswer AnswerLevel2 { get; set; }

        [Association(ThisKey = nameof(Lvl3Answer), OtherKey = nameof(CustomerListItemAnswer.AnswerId))]
        public CustomerListItemAnswer AnswerLevel3 { get; set; }
    }
}
