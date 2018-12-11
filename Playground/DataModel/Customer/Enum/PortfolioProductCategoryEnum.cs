using PiraeusBank.BI.ICE2.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer.Enum
{
    //CAUTION: The enum value is what the portfolio rpc returns as product group. The enum code is what the table with the produt hierarchy contains
    //TODO: REPLACE THE ACTUAL TABLE WITH THE CRS161P
    public enum PortfolioProductCategoryEnum
    {
        [Description("ΚΑΤΑΘΕΣΕΙΣ"), EnumCode("7")] 
        Deposits = 37,        
        [Description("ΧΟΡΗΓΗΣΕΙΣ"), EnumCode("5")]
        Credits = 5,
        [Description("ΑΣΦΑΛΙΣΤΙΚΑ"), EnumCode("4")]
        Insurance = 4,
        [Description("ΕΠΕΝΔΥΣΕΙΣ"), EnumCode("8")]
        Investment = 38,
        [Description("ΕΠΕΝΔ. ΥΠΗΡΕΣΙΕΣ"), EnumCode("9")]
        InvestmentServices = 39,
        [Description("ΥΠΗΡΕΣΙΕΣ"), EnumCode("6")]
        Services = 6,
        [Description("ΑΙΤΗΣΕΙΣ")]
        Applications = 9999999
    }

}
