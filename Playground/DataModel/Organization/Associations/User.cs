using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Organization
{
    public partial class User
    {
        [Association(ThisKey = nameof(SystemUserId), OtherKey = nameof(UserExtension.SystemUserId))]
        public UserExtension UserExtensionData { get; set; }
    }
}
