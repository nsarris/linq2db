using System;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{
    public class ListCategoryAttributes : Attribute
    {
        public CountersTypeEnum CountersType { get; set; }  
        public CustomerListCategoryType CategoryType { get; set; }
        public string PathName { get; set; }
    }
}
