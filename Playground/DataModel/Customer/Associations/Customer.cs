using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToDB.Mapping;
using PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Organization;


namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{	
    public partial class Customer
    {
        [Association(ThisKey = nameof(CustomerCategoryTypeId) + "," + nameof(CustomerCategoryType), OtherKey = nameof(Classification.TypeId) + "," + nameof(Classification.ClassType))]
        public Classification Type { get; set; }

        [Association(ThisKey = nameof(OrganizationLegalTypeId) + "," + nameof(OrganizationLegalClassType), OtherKey = nameof(Classification.TypeId) + "," + nameof(Classification.ClassType))]
        public Classification LegalForm { get; set; }

        [Association(ThisKey = nameof(ResponsibleBranchIpId), OtherKey = nameof(Organization.Branch.IpId))]
        public Branch ResponsibleBranch { get; set; }

        [Association(ThisKey = nameof(IndividualOccupationId), OtherKey = nameof(DataModel.Customer.Profession.IndvOcptnTypeId))]
        public Profession Profession { get; set; }

        [Association(ThisKey = nameof(OrganizationIndustryCode), OtherKey = nameof(DataModel.Customer.EconomicActivity.IndsClassId))]
        public EconomicActivity EconomicActivity { get; set; }

        [Association(ThisKey = nameof(OccupationOrIndustryId), OtherKey = nameof(ProfessionsEconomicActivitiesUnion.Id))]
        public ProfessionsEconomicActivitiesUnion OccupationOrIndustry { get; set; }

        [Association(ThisKey = nameof(CrsId), OtherKey = nameof(VipXCustomers.IpId))]
        public VipXCustomers Vip { get; set; }

        [Association(ThisKey = nameof(CustomerMainIdType) + "," + nameof(CustomerMainIdClass), OtherKey = nameof(Classification.TypeId) + "," + nameof(Classification.ClassType))]
        public Classification IdentityClassification { get; set; }
    }
}
