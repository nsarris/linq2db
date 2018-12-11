using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.SalesOpportunity
{
    public enum CustomerResponseEnum
    {
        NoResponse = 0,
        Denied = 1,
        Cold = 2,
        Neutral = 3,
        Hot = 4,
        Accepted = 5
    }
}
