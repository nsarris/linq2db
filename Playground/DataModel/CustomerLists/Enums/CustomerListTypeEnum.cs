using System.Linq;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{
    public enum CustomerListTypeEnum
    {
        [CustomerListTypeAttributes(Category = CustomerListCategoryEnum.Unknown, VisibleOnCustomerLists = false, VisibilityType = ListVisibilityEnum.AlwaysVisible)]
        CustomerSearch = 0,

        [CustomerListTypeAttributes(Category = CustomerListCategoryEnum.Expirations, VisibleOnCustomerLists = true, PathName = "Νομιμοποιήσεις", VisibilityType = ListVisibilityEnum.AlwaysVisible, AllowEditHistoric = true)]
        LegitimacyExpiration = 1,
        [CustomerListTypeAttributes(Category = CustomerListCategoryEnum.Expirations, VisibleOnCustomerLists = true, PathName = "Προθεσμιακές", VisibilityType = ListVisibilityEnum.AlwaysVisible, AllowEditHistoric = true)]
        TimeDepositExpiration = 2,
        [CustomerListTypeAttributes(Category = CustomerListCategoryEnum.Expirations, VisibleOnCustomerLists = true, PathName = "Ασφαλιστικά", VisibilityType = ListVisibilityEnum.AlwaysVisible, AllowEditHistoric = true)]
        InsuranceExpiration = 3,
        [CustomerListTypeAttributes(Category = CustomerListCategoryEnum.ToDos, VisibleOnCustomerLists = true, PathName = "FATCA", VisibilityType = ListVisibilityEnum.AlwaysVisible, AllowEditHistoric = true)]
        FatcaExpiration = 4,
        [CustomerListTypeAttributes(Category = CustomerListCategoryEnum.ToDos, VisibleOnCustomerLists = true, PathName = "TEKE", VisibilityType = ListVisibilityEnum.AlwaysVisible, AllowEditHistoric = true)]
        TekeExpiration = 5,

        [CustomerListTypeAttributes(Category = CustomerListCategoryEnum.Expirations, VisibleOnCustomerLists = false, VisibilityType = ListVisibilityEnum.AlwaysVisible)]
        AcceptanceExpiration = 6,
        [CustomerListTypeAttributes(Category = CustomerListCategoryEnum.Sales, VisibleOnCustomerLists = true, PathName = "Καμπάνιες", VisibilityType = ListVisibilityEnum.OutOfBasedVisibility, AllowEditHistoric = false)]
        CampaignCustomer = 7,
        [CustomerListTypeAttributes(Category = CustomerListCategoryEnum.Unknown, VisibleOnCustomerLists = false)]
        FavoriteCustomer = 8,
        [CustomerListTypeAttributes(Category = CustomerListCategoryEnum.Sales, VisibleOnCustomerLists = true, PathName = "Εμπορική Πρόταση", VisibilityType = ListVisibilityEnum.AlwaysVisible, AllowEditHistoric = true)]
        NBA = 9,
        [CustomerListTypeAttributes(Category = CustomerListCategoryEnum.Sales, VisibleOnCustomerLists = false)]
        CsaAlert = 10,
              
        [CustomerListTypeAttributes(Category = CustomerListCategoryEnum.RMA, VisibleOnCustomerLists = true, ListSourceType = CustomerListSourceTypeEnum.External, RMAListType = RMAListsEnum.Actual, PathName = "Καμπάνια οι Πελάτες μου", VisibilityType = ListVisibilityEnum.AlwaysVisible)]
        RMA = 1001,
        [CustomerListTypeAttributes(Category = CustomerListCategoryEnum.RMA, VisibleOnCustomerLists = false, ListSourceType = CustomerListSourceTypeEnum.External, RMAListType = RMAListsEnum.Potential, PathName = "Καμπάνια οι Πελάτες μου", VisibilityType = ListVisibilityEnum.AlwaysVisible)]
        RMAPotential = 1002,
        [CustomerListTypeAttributes(Category = CustomerListCategoryEnum.RMA, VisibleOnCustomerLists = true, ListSourceType = CustomerListSourceTypeEnum.External, RMAListType = RMAListsEnum.Indirect, PathName = "Καμπάνια οι Πελάτες μου", VisibilityType = ListVisibilityEnum.AlwaysVisible)]
        RMAIndirect = 1003,


        [CustomerListTypeAttributes(Category = CustomerListCategoryEnum.Sales, VisibleOnCustomerLists = false, ListSourceType = CustomerListSourceTypeEnum.External, PathName = "Προωθητική Ενέργεια")]
        Siebel = 2001,
        [CustomerListTypeAttributes(Category = CustomerListCategoryEnum.Unknown, VisibleOnCustomerLists = false, ListSourceType = CustomerListSourceTypeEnum.External, PathName = "Εμπορική Προσέγγιση")]
        Proposals = 2002,
        [CustomerListTypeAttributes(Category = CustomerListCategoryEnum.Sales, VisibleOnCustomerLists = true, PathName = "Ευκαιρία Πώλησης", VisibilityType = ListVisibilityEnum.AlwaysVisible, AllowEditHistoric = true)]
        SalesOpportunities = 11,

    }
    public static class CustomerListTypeEnumExtensions
    {
        public static string GetPathName(this CustomerListTypeEnum currentListEnum)
        {
            var listAttributes = ((CustomerListTypeAttributes)
                                                    typeof(CustomerListTypeEnum)
                                                    .GetMember(currentListEnum.ToString())
                                                    .FirstOrDefault()
                                                    .GetCustomAttributes(typeof(CustomerListTypeAttributes), false)
                                                    .FirstOrDefault());

            return listAttributes.PathName;

        }
    }


}
