using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Activity
{
    public partial class Purpose
    {
        [Association(ThisKey = nameof(Id), OtherKey = nameof(DataModel.Activity.ActivityXPurpose.PurposeId))]
        public ActivityXPurpose ActivityXPurpose { get; set; }
    }
}
