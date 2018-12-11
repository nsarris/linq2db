using LinqToDB.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.RMA
{
    public class RMAOpportunity
    {
        [Column(Name = "OpportunityID"), NotNull] public int Id { get; set; }
        [Column(Name = "Employee"), NotNull] public string Employee { get; set; }
        [Column(Name = "IpId"), NotNull] public int IpId { get; set; }
        [Column(Name = "Customer"), Nullable] public string Customer { get; set; }
        [Column(Name = "Title"), Nullable] public string Title { get; set; }
        [Column(Name = "Product"), Nullable] public string Product { get; set; }
        [Column(Name = "Stage"), Nullable] public string Stage { get; set; }
        [Column(Name = "Status"), Nullable] public string Status { get; set; }
        [Column(Name = "Amount"), Nullable] public decimal Amount { get; set; }
        [Column(Name = "Comments"), Nullable] public string Comments { get; set; }
        [Column(Name = "StartDate"), NotNull] public DateTime StartDate { get; set; }
        [Column(Name = "EndDate"), Nullable] public DateTime EndDate { get; set; }
        [Column(Name = "LastModifiedDate"), Nullable] public DateTime LastModifiedDate { get; set; }
        [Column(Name = "CampaignID"), Nullable] public string CampaignID { get; set; }
        [Column(Name = "CreatedBy"), Nullable] public string CreatedBy { get; set; }
        [Column(Name = "CreationDate"), Nullable] public DateTime CreationDate { get; set; }
        [Column(Name = "OpportunityTypeID"), Nullable] public int OpportunityTypeID { get; set; }     
    }
}
