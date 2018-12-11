using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;
using PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Organization;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Activity
{
    public partial class ActivityXPurpose
    {
        [Association(ThisKey = nameof(ActivityId), OtherKey = nameof(DataModel.Activity.Activity.Id))]
        public Activity Activity { get; set; }
        [Association(ThisKey = nameof(PurposeId), OtherKey = nameof(DataModel.Activity.Purpose.Id))]
        public Purpose Purpose { get; set; }

        [Association(ThisKey = nameof(ProductId) + "," + nameof(ProductLevel), OtherKey = nameof(Organization.Product.ProductId) + "," + nameof(Organization.Product.CurrentLevel))]
        public Product Product { get; set; }

        //[Association(ThisKey = nameof(ProductId) + "," + nameof(ProductLevel), OtherKey = nameof(Organization.ProductView.ProductId) + "," + nameof(Organization.ProductView.CurrentLevel))]
        //public ProductView ProductView { get; set; }

    }
}
