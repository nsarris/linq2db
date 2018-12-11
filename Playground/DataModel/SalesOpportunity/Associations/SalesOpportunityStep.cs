using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.SalesOpportunity
{
    //[InheritanceMapping(Code = true, Type = typeof(SalesOpportunityLastStep))]
    public partial class SalesOpportunityStep
    {
        [Association(ThisKey = nameof(Id), OtherKey = nameof(SalesOpportunityStepXActivity.OpportunityStepId))]
        public SalesOpportunityStepXActivity OpportunityStepXActivity { get; set; }

        [Association(ThisKey = nameof(Id), OtherKey = nameof(SalesOpportunityMetadata.SalesOpportunityStepId))]
        public SalesOpportunityMetadata Metadata { get; set; }

        [Association(ThisKey = nameof(CustomerResponse), OtherKey = nameof(SalesOpportunityResponse.Id))]
        public SalesOpportunityResponse Response { get; set; }

        [Association(ThisKey = nameof(SalesOpportunityId), OtherKey = nameof(SalesOpportunity.Id))]
        public SalesOpportunity Opportunity { get; set; }
    }
    
}
