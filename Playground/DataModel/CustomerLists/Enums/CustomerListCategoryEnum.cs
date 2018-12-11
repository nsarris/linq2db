using System.ComponentModel;
using System.Linq;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{
    public enum CustomerListCategoryType
    {
        Default = 1,
        RM = 2
    }

    public enum CustomerListCategoryEnum
    {
        Unknown = 0,

        [ListCategoryAttributes(CountersType = CountersTypeEnum.SingleValue, CategoryType = CustomerListCategoryType.Default, PathName = "Ληξιάρια")]
        [Description("Ληξιάρια")]
        Expirations = 1,

        [ListCategoryAttributes(CountersType = CountersTypeEnum.SingleValue, CategoryType = CustomerListCategoryType.Default, PathName = "Εκκρεμότητες")]
        [Description("Εκκρεμότητες")]
        ToDos = 2,

        [ListCategoryAttributes(CountersType = CountersTypeEnum.SingleValue, CategoryType = CustomerListCategoryType.Default, PathName = "Πωλησιακά")]
        [Description("Πωλήσεις")]
        Sales = 3,

        [ListCategoryAttributes(CountersType = CountersTypeEnum.SingleValue, CategoryType = CustomerListCategoryType.RM, PathName = "RMA")]
        [Description("Οι Πελάτες μου")]
        RMA = 4
    }

    public static class ListCategoryExtensions
    {
        public static CountersTypeEnum CountersType(this CustomerListCategoryEnum currentCategory)
        {
            var listAttributes = ((ListCategoryAttributes)
                                                    typeof(CustomerListCategoryEnum)
                                                    .GetMember(currentCategory.ToString())
                                                    .FirstOrDefault()
                                                    .GetCustomAttributes(typeof(ListCategoryAttributes), false)
                                                    .FirstOrDefault());

            return listAttributes.CountersType;

        }

        public static CustomerListCategoryType CategoryType(this CustomerListCategoryEnum currentCategory)
        {
            var listAttributes = ((ListCategoryAttributes)
                                                    typeof(CustomerListCategoryEnum)
                                                    .GetMember(currentCategory.ToString())
                                                    .FirstOrDefault()
                                                    .GetCustomAttributes(typeof(ListCategoryAttributes), false)
                                                    .FirstOrDefault());

            return listAttributes.CategoryType;

        }

        public static string GetPathName(this CustomerListCategoryEnum currentCategory)
        {
            var listAttributes = ((ListCategoryAttributes)
                                                    typeof(CustomerListCategoryEnum)
                                                    .GetMember(currentCategory.ToString())
                                                    .FirstOrDefault()
                                                    .GetCustomAttributes(typeof(ListCategoryAttributes), false)
                                                    .FirstOrDefault());

            return listAttributes.PathName;

        }
    }
}
