using PiraeusBank.BI.ICE2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer.Enum
{
    public enum ESignatureEnum
    {
        [EnumCode("Y")] Active = 1,
        [EnumCode("I")] InactiveButEligible = 2,
        [EnumCode("N")] Inactive = 3,
    }
}
