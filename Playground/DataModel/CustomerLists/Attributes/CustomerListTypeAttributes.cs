using System;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{
    public class CustomerListTypeAttributes : Attribute
    {
        public CustomerListCategoryEnum Category { get; set; }
        public bool VisibleOnCustomerLists { get; set; }
        public CustomerListSourceTypeEnum ListSourceType { get; set; }

        public RMAListsEnum RMAListType { get; set; }
        public ListVisibilityEnum VisibilityType { get; set; }
        public bool AllowEditHistoric{ get; set; }
        public string PathName { get; set; }

    }
}
