using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel
{
    public partial class CsaAlert
    {
        [Association(ThisKey = nameof(CrsId), OtherKey = nameof(DataModel.Customer.Customer.CrsId))]
        public DataModel.Customer.Customer Customer { get; set; }

        [Association(ThisKey = nameof(Status1TypeId) + "," + nameof(Status1ClassType), OtherKey = nameof(Classification.TypeId) + "," + nameof(Classification.ClassType))]
        public Classification Status1 { get; set; }
}
}
