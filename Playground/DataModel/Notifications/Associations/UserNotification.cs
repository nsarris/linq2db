using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Notifications
{
    public partial class UserNotification
    {
        [Association(ThisKey = nameof(TypeId), OtherKey = nameof(Notifications.NotificationType.Id))]
        public NotificationType NotificationType { get; set; }
    }
}
