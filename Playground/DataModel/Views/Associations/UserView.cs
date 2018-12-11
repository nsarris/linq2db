using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Views
{
    public partial class UserView
    {
        [Association(ThisKey = nameof(Id), OtherKey = nameof(UserViewColumn.ViewId))]
        public IEnumerable<UserViewColumn> Properties { get; set; }      
    }
}
