using System.ComponentModel;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{
    public enum RMAListsEnum
    {
        [Description("Υπάρχοντες Πελάτες")]
        Actual = 0,
        [Description("Δυνητικοί Πελάτες")]
        Potential = 1,
        [Description("Έμμεσοι Πελάτες")]
        Indirect = 2
    }
}
