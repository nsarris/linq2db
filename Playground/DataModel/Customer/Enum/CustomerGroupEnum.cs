using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
    public enum CustomerGroupEnum
    {
        [Description("01")]
        CardsOnline = 1,
        [Description("02")]
        Vip = 2
    }
}
