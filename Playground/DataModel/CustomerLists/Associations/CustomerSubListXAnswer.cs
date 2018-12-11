using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{
    //[InheritanceMapping(Code = 0, Type = typeof(CustomerListXAnswer))]
    public partial class CustomerSubListXAnswer
	{
        [Association(ThisKey = nameof(AnswerId), OtherKey = nameof(CustomerListItemAnswer.AnswerId))]
        public List<CustomerListItemAnswer> Answers { get; set; }
    }

    [Table(Name = "ANSRLTPF", Schema = "XCRS")]
    public partial class CustomerListXAnswer : CustomerSubListXAnswer
    {
    }
}
