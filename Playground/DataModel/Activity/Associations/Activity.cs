using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;
using PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Organization;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Activity
{
    public partial class Activity
    {
        [Association(ThisKey = nameof(Id), OtherKey = nameof(ActivityMetadata.ActivityId))]
        public ActivityMetadata Metadata { get; set; }
        [Association(ThisKey = nameof(Id), OtherKey = nameof(Participant.ActivityId))] 
        public List<Participant> Participants { get; set; }
        [Association(ThisKey = nameof(Id), OtherKey = nameof(DataModel.Activity.ActivityXPurpose.ActivityId))]
        public ActivityXPurpose ActivityXPurpose { get; set; }
        [Association(ThisKey = nameof(ContactMediumId), OtherKey = nameof(DataModel.Activity.ContactMedium.Id))]
        public ContactMedium ContactMedium { get; set; }
        [Association(ThisKey = nameof(OriginBranchId), OtherKey = nameof(Organization.Branch.BranchIdMnem))]
        public Branch Branch { get; set; }
        [Association(ThisKey = nameof(Creator), OtherKey = nameof(Organization.User.SystemUserId))]
        public User User { get; set; }
    }
}
