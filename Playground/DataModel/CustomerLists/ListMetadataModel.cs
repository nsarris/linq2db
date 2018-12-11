using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{
    public class ListMetadataModel
    {
        public const string COMMON_URL1NAME = "Url1";
        public const string COMMON_URL2NAME = "Url2";

        public const string SIEBEL_CAMPAIGNID = "CampaignId";
        public const string SIEBEL_OFFERID = "OfferId";
        public const string SIEBEL_TREATMENTID = "TreatmentId";

        public ListMetadataModel()
        {
            Common = new CommonMetadata();
            CustomProperties = new Dictionary<string, string>();
        }

        public CommonMetadata Common { get; set; }
        public Dictionary<string, string> CustomProperties { get; set; }
    }

    public class CommonMetadata
    {
        public Dictionary<string, string> URLs { get; set; }
    }
}

