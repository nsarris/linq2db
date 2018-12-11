using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using LinqToDB.Mapping;
using PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.NBA
{

    public partial class CustomerNextBestActionHistory
    {

        //[Association(ThisKey = nameof(NbaId), OtherKey = nameof(NBA.NextBestAction.NbaId))]
        //public NextBestAction NextBestAction { get; set; }

        [Association(CanBeNull = true, ExpressionPredicate = nameof(NBAPredicate))]
        public CustomerSubList NextBestAction { get; set; }

        public static Expression<Func<CustomerNextBestActionHistory, CustomerSubList, bool>> NBAPredicate { get; } = (x, y) => y.SublistId == x.NbaId && y.ListId == ((int)CustomerListTypeEnum.NBA).ToString().PadLeft(3, '0');

        [Association(ThisKey = nameof(Lvl2Answer) + "," + nameof(Lvl3Answer), OtherKey = nameof(CustomerListItemAnswer.ParentAnswerId) + "," + nameof(CustomerListItemAnswer.AnswerId))]
        public CustomerListItemAnswer Answer { get; set; }

        [Association(ThisKey = nameof(Lvl1Answer), OtherKey = nameof(CustomerListItemAnswer.AnswerId))]
        public CustomerListItemAnswer AnswerLevel1 { get; set; }

        [Association(ThisKey = nameof(Lvl2Answer), OtherKey = nameof(CustomerListItemAnswer.AnswerId))]
        public CustomerListItemAnswer AnswerLevel2 { get; set; }

        [Association(ThisKey = nameof(Lvl3Answer), OtherKey = nameof(CustomerListItemAnswer.AnswerId))]
        public CustomerListItemAnswer AnswerLevel3 { get; set; }


        [Association(ThisKey = nameof(UserOfAction), OtherKey = nameof(Organization.User.SystemUserId))]
        public Organization.User User { get; set; }

        [Association(ThisKey = nameof(ResponceUnit), OtherKey = nameof(Organization.Branch.BranchIdMnem))]
        public Organization.Branch Branch { get; set; }
    }
}
