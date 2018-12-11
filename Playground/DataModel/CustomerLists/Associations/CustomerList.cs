using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB.Mapping;
using PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{

    public partial class CustomerList
    {
        [Association(ThisKey = nameof(ListId), OtherKey = nameof(CustomerSubList.ListId))]
        public List<CustomerSubList> SubLists { get; set; }

        [Association(ThisKey = nameof(ListId), OtherKey = nameof(CustomerListXAnswer.ListId))]
        public List<CustomerListXAnswer> ListXAnswers { get; set; }

        //[Association(ThisKey = nameof(Listid), OtherKey = nameof(CustomerListLiteral.ClassType))]
        //public CustomerListLiteral Literal;

        [Association(ThisKey = nameof(ListId), OtherKey = nameof(CustomerListStatus.ListId))]
        public List<CustomerListStatus> Statuses { get; set; }

        [Association(ThisKey = nameof(ListId), OtherKey = nameof(ListActions.ListId))]
        public List<ListActions> Actions { get; set; }
    }
}
