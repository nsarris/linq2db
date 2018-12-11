using LinqToDB.Mapping;
using PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Organization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.SalesOpportunity
{
    public partial class SalesOpportunity
    {
        [Association(ThisKey = nameof(Id), OtherKey = nameof(SalesOpportunityStep.SalesOpportunityId))]
        public List<SalesOpportunityStep> Steps { get; set; }
                
        [Association(CanBeNull = true, ExpressionPredicate = nameof(LastResponsePredicate))]
        public SalesOpportunityStep LastResponseStep { get; set; }

        public static Expression<Func<SalesOpportunity, SalesOpportunityStep, bool>> LastResponsePredicate { get; } = (x, y) => y.SalesOpportunityId == x.Id && y.IsLatestResponse == 1;

        [Association(CanBeNull = true, ExpressionPredicate = nameof(NextScheduledPredicate))]
        public SalesOpportunityStep NextScheduledStep { get; set; }

        public static Expression<Func<SalesOpportunity, SalesOpportunityStep, bool>> NextScheduledPredicate { get; } = (x, y) => y.SalesOpportunityId == x.Id && y.IsNextScheduled == 1;

        [Association(ThisKey = nameof(ProductId) + "," + nameof(ProductLevel), OtherKey = nameof(Organization.Product.ProductId) + "," + nameof(Organization.Product.CurrentLevel))]
        public Product Product { get; set; }

        [Association(ThisKey = nameof(IpId), OtherKey = nameof(DataModel.Customer.Customer.CrsId))]
        public Customer.Customer Customer { get; set; }

        [Association(ThisKey = nameof(UserLastModified), OtherKey = nameof(Organization.User.SystemUserId))]
        public Organization.User LastUpdateUser { get; set; }
    }
}
