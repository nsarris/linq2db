using LinqToDB.Mapping;
using PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Arrangement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Portfolio
{
    public partial class CustomerPortfolioItem
    {
        //[Association(ThisKey = nameof(Username) + "," 
        //                     + nameof(ProductLevel1) + "," 
        //                     + nameof(ProductLevel2) + "," 
        //                     + nameof(ProductLevel3) + "," 
        //                     + nameof(GroupsIpId) + "," 
        //                     + nameof(ProductClassType) + "," 
        //                     + nameof(IpId) + "," 
        //                     + nameof(ArrangementId) + "," 
        //                     + nameof(RelationshipClassType),
        //             OtherKey = nameof(ArrangementParentIndicator.Username) + ","
        //                     + nameof(ArrangementParentIndicator.ProductLevel1) + ","
        //                     + nameof(ArrangementParentIndicator.ProductLevel2) + ","
        //                     + nameof(ArrangementParentIndicator.ProductLevel3) + ","
        //                     + nameof(ArrangementParentIndicator.GroupsIpId) + ","
        //                     + nameof(ArrangementParentIndicator.ProductClassType) + ","
        //                     + nameof(ArrangementParentIndicator.IpId) + ","
        //                     + nameof(ArrangementParentIndicator.ArrangementId) + ","
        //                     + nameof(ArrangementParentIndicator.RelationshipClassType))]
        //public ArrangementParentIndicator ChildrenIndicator { get; set; }

        [Association(ThisKey = nameof(Username) + ","
                             + nameof(IpId) + ","
                             + nameof(ArrangementId),
                     OtherKey = nameof(ArrangementChildrenDetails.Username) + ","
                             + nameof(ArrangementChildrenDetails.IpId) + ","
                             + nameof(ArrangementChildrenDetails.ParentArrangementId))]
        public List<ArrangementChildrenDetails> ChildrenDetails { get; set; }
    }
}
