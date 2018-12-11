using PiraeusBank.BI.ICE2.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer.Enum
{
    public enum PortfolioHistoricalEnum
    {
        [Description("Όλα"), EnumCode("0")] All = 0,
        [Description("Ενεργά"), EnumCode("1")] Active = 1,
        [Description("Ιστορικά"), EnumCode("2")] Historical = 2,
    }

    public enum ArrangementHistoricalEnum
    {
        [Description("Ενεργό"), EnumCode("1")] Active = 1,
        [Description("Ιστορικό"), EnumCode("2")] Historical = 2,
        [Description("Μελλοντικά"), EnumCode("3")] Future = 3,
    }
}
