using PiraeusBank.BI.ICE2.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Organization
{
    public enum ClassificationsEnum
    {
        [EnumCode("U08")] CustomerArrangementRelationship,
        [EnumCode("U13")] OfficerTypes,
        [EnumCode("U18")] TermOfConditionType,
        [EnumCode("U21")] IdentityType,
        [EnumCode("U24")] CustomerRelationshipTypes,
        [EnumCode("U28")] CustomerCategoryTypes,
        [EnumCode("U42")] DeletionReason,
        [EnumCode("U50")] Currency,
        [EnumCode("U52")] LegalForm,
        [EnumCode("U53")] OrganisationType,
        [EnumCode("U56")] Country,
        [EnumCode("U60")] ExternalSystem,
        [EnumCode("U62")] ArmyCorpsType,
        [EnumCode("UE0")] CustomerList,
        [EnumCode("UE1")] CustomerListAnswerStatus,
        [EnumCode("UE2")] ActivityStatus,
        [EnumCode("UE5")] Product,
        [EnumCode("UE6")] SalesOpportunityStatus,
        [EnumCode("UE7")] CustomerRelationshipCategories,
        [EnumCode("UE8")] VirtualCustomerRelationshipTypes,
    }

    public enum CustomerCategoryTypeClassificationsEnum
    {
        [EnumCode("ATE")] ATE,
        [EnumCode("EBK")] EBK,
        [EnumCode("IND")] IND,
        [EnumCode("MKD")] MKD,
        [EnumCode("ORG")] ORG,
        [EnumCode("PBL")] PBL,
        [EnumCode("STF")] STF,
        [EnumCode("STG")] STG,
        [EnumCode("STX")] STX,
        [EnumCode("XRH")] XRH,
        [EnumCode("GRP")] GRP
    }
    public enum AlertStatusesClassificationsEnum
    {
        [EnumCode("021")] Active,
        [EnumCode("022")] Failed,
        [EnumCode("023")] Assigned,
        [EnumCode("024")] SucceededAndClosed,
    }

    public enum RelationshipGroupsEnum
    {
        [EnumCode("001")] Officers,
    }

    public enum RelationshipWithBankEnum
    {
        [EnumCode("001")] ResponsibleBranch,
    }

    public enum RelationWithGroupEnum
    {
        [EnumCode("033")] IsMemberOfGroup,
        [EnumCode("533")] HasMember,
    }

    public enum RepresentativeRelationshipTypeEnum
    {
        [EnumCode("20")] IsRepresentative,
        [EnumCode("520")] HasRepresentative,
        [EnumCode("10")] IsOwner,
        [EnumCode("510")] HasOwner,
        [EnumCode("17")] IsShareHolder,
        [EnumCode("517")] HasShareHolder,
        [EnumCode("39")] IsAssociate,
        [EnumCode("14")] HasAssociate,
        [EnumCode("55")] HasBusinessRelationship,
        [EnumCode("555")] ConnectedWithBusinessRelationship,
        [EnumCode("29")] BelongsTo,
        [EnumCode("529")] CustomerOwnership,
        [EnumCode("57")] IsChiefExecutiveOfficer,
        [EnumCode("557")] HasChiefExecutiveOfficer,
        [EnumCode("59")] IsDiplomaticCorpsPresident,
        [EnumCode("559")] HasDiplomaticCorpsPresident,
        [EnumCode("58")] IsDiplomaticCorpsMember,
        [EnumCode("558")] HasDiplomaticCorpsMember,
        [EnumCode("13")] IsLegalCounvelor,
        [EnumCode("513")] HasLegalCounvelor,
        [EnumCode("5")] IsPlenipotentiary,
        [EnumCode("505")] HasPlenipotentiary,
        [EnumCode("62")] IsAuthorizedForInternetBanking,
        [EnumCode("562")] HasAuthorizedForInternetBanking,
        [EnumCode("18")] IsPersonOfCommunication,
        [EnumCode("518")] HasPersonOfCommunication,
        [EnumCode("35")] IsPersonOfCommunicationForGroups,
        [EnumCode("535")] HasPersonOfCommunicationForGroups,
    }

    public enum AnswerStatusEnum
    {
        [EnumCode("010")] UnreachableCustomer
    }

    public static class ClassificationsEnumExtensions
    {
        public static string GetCode(this ClassificationsEnum classification)
        {
            return EnumHelper.GetCodeFromValue(classification);
        }
        public static string GetCode(this AlertStatusesClassificationsEnum classification)
        {
            return EnumHelper.GetCodeFromValue(classification);
        }
        public static string GetCode(this AnswerStatusEnum classification)
        {
            return EnumHelper.GetCodeFromValue(classification);
        }
    }
}
