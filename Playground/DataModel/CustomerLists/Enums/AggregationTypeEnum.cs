using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{
    public enum AggregationTypeEnum
    {
        None = 0,
        Count = 1,
        Sum = 2,
        Average = 3,
        Min = 4,
        Max = 5
    }
}
