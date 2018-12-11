using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Organization
{
    public enum UserStatus
    {
        [Description("Active")]
        Active = 1,
        [Description("Disabled")]
        Disabled = 2
    }
    public static class MyEnumExtensions
    {
        public static string ToDescriptionString(this UserStatus val)
        {
            DescriptionAttribute[] attributes = (DescriptionAttribute[])val.GetType().GetField(val.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : string.Empty;
        }
    }
}
