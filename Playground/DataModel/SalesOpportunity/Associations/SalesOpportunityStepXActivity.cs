using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.SalesOpportunity
{
    public partial class SalesOpportunityStepXActivity
    {
        [Association(ThisKey = nameof(ActivityId), OtherKey = nameof(DataModel.Activity.Activity.Id))]
        public Activity.Activity Activity { get; set; }
    }
}
