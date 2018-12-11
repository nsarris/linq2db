using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{
    public partial class CustomerListItemAnswer
    {
        [Association(ThisKey = nameof(AnswerId), OtherKey = nameof(CustomerSubListXAnswer.AnswerId))]
        public List<CustomerSubListXAnswer> AnswerLists { get; set; }

        [Association(ThisKey = nameof(Status1TypeId) + "," + nameof(Status1ClassType), OtherKey = nameof(Classification.TypeId) + "," + nameof(Classification.ClassType))]
        public Classification Status { get; set; }

        [Association(ThisKey = nameof(Status1TypeId) + "," + nameof(Status1ClassType), OtherKey = nameof(ClassificationExtension.TypeId) + "," + nameof(ClassificationExtension.ClassType))]
        public ClassificationExtension StatusExtension { get; set; }
    }
}
