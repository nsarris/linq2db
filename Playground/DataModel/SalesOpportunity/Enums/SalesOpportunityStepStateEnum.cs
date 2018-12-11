using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.SalesOpportunity
{
    public enum SalesOpportunityStepStateEnum
    {
        Unknown = 0,
        Scheduled = 1,
        Complete = 2,
        Canceled = 3,
        Abandoned = 4
    }
}
