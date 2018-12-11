using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Arrangement
{
	public partial class ArrangementExtraRelationship
	{
        [Association(ThisKey = nameof(RelationshipTypeId) + "," + nameof(RelationshipClassType), OtherKey = nameof(Classification.TypeId) + "," + nameof(Classification.ClassType))]
        public Classification RelationshipType { get; set; }

        [Association(ThisKey = nameof(IpId), OtherKey = nameof(Customer.CustomerCommon.IpId))]
        public Customer.CustomerCommon CustomerCommon { get; set; }

        public static Expression<Func<ArrangementExtraRelationship, Customer.CustomerPhysicalEntity, bool>> CustomerPhysicalPredicate { get; } = (x, y) => x.IpId == y.IpId && x.CustomerCommon.CustomerTypeCode == "I";

        [Association(ExpressionPredicate = nameof(CustomerPhysicalPredicate))]
        public Customer.CustomerPhysicalEntity CustomerPhysical { get; set; }

        public static Expression<Func<ArrangementExtraRelationship, Customer.CustomerLegalEntity, bool>> CustomerLegalPredicate { get; } = (x, y) => x.IpId == y.IpId && x.CustomerCommon.CustomerTypeCode == "O";

        [Association(ExpressionPredicate = nameof(CustomerLegalPredicate))]
        public Customer.CustomerLegalEntity CustomerLegal { get; set; }
    }
}
