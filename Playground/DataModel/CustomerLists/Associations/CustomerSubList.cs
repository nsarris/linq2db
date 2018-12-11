using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB.Mapping;
using Newtonsoft.Json;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{
    public partial class CustomerSubList
    {
        [Association(ThisKey = nameof(ListId) + "," + nameof(SublistId), OtherKey = nameof(CustomerSubListXAnswer.ListId) + "," + nameof(CustomerSubListXAnswer.SublistId))]
        public List<CustomerSubListXAnswer> SubListXAnswers { get; set; }
    }   
}
