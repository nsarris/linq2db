using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.NBA
{
	[Table(Name = "NBAPROPF", Schema = "XCRS")]
	public partial class NextBestAction
	{
		[Column(IsPrimaryKey = true, Name = "NBAPID", DataType = DataType.Decimal, CanBeNull = true, Precision = 11, Scale = 0)]
		public long NbaId { get; set; }
		[Column(Name = "CAMPCODE", DataType = DataType.Char, CanBeNull = true, Length = 9)]
		public string CampaignId { get; set; }
		[Column(Name = "PRODLVL", DataType = DataType.Char, CanBeNull = true, Length = 7)]
		public string ProductLevel { get; set; }
		[Column(Name = "CMPNAME", DataType = DataType.Char, CanBeNull = true, Length = 250)]
		public string Name { get; set; }
		[Column(Name = "CMPDESC", DataType = DataType.Char, CanBeNull = true, Length = 250)]
		public string Description { get; set; }
		[Column(Name = "OFFNAME", DataType = DataType.Char, CanBeNull = true, Length = 250)]
		public string OfferName { get; set; }
		[Column(Name = "OFFDESC", DataType = DataType.Char, CanBeNull = true, Length = 250)]
		public string OfferDescription { get; set; }
		[Column(Name = "PROPTYPE", DataType = DataType.Char, CanBeNull = true, Length = 11)]
		public string ProposalType { get; set; }
		[Column(Name = "CR9UA", DataType = DataType.Char, CanBeNull = true, Length = 1)]
		public string HistoricStatus { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Decimal, CanBeNull = true, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Decimal, CanBeNull = true, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
		[Column(Name = "USRID", DataType = DataType.Char, CanBeNull = true, Length = 10)]
		public string UserOfLastUpdate { get; set; }
		[Column(Name = "PROD_ID", DataType = DataType.Decimal, CanBeNull = false, Precision = 8, Scale = 0)]
		public int ProductId { get; set; }
		[Column(Name = "PROD_DESC", DataType = DataType.Char, CanBeNull = false, Length = 250)]
		public string ProductDescription { get; set; }
		[Column(Name = "ACTNTPID", DataType = DataType.Decimal, CanBeNull = false, Precision = 8, Scale = 0)]
		public int ActionId { get; set; }
		[Column(Name = "ACTNDESC", DataType = DataType.Char, CanBeNull = false, Length = 250)]
		public string ActionDescription { get; set; }
		[Column(Name = "RESPNSET", DataType = DataType.Char, CanBeNull = true, Length = 250)]
		public string AnswerSet { get; set; }
	}
}
