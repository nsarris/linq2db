using LinqToDB;
using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Arrangement
{
	public partial class ArrangementParentIndicator
	{
        [Association(ThisKey = nameof(ArrangementId), OtherKey = nameof(ArrangementChildrenDetails.ParentArrangementId))]
        public List<ArrangementChildrenDetails> ChildrenDetails { get; set; }
    }
}
