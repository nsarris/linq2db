using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.NBA
{
	[Table(Name = "CUSTNBA", Schema = "XCRS")]
	public partial class CustomerNextBestAction
	{
		[Column(IsPrimaryKey = true, Name = "NBAIDRA", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long Id { get; set; }
		[Column(Name = "LISTID1", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ListId { get; set; }
		[Column(Name = "IPIDCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int IpId { get; set; }
		[Column(Name = "NBAPID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long NbaId { get; set; }
		[Column(Name = "OFFER", DataType = DataType.Char, CanBeNull = false, Length = 250)]
		public string OfferName { get; set; }
		[Column(Name = "NBATYPE", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string NbaType { get; set; }
		[Column(Name = "DURATION", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string Duration { get; set; }
		[Column(Name = "CRTDATE", DataType = DataType.Date, CanBeNull = false)]
		public DateTime StartDate { get; set; }
		[Column(Name = "ENDDATE", DataType = DataType.Date, CanBeNull = false)]
		public DateTime EndDate { get; set; }
		[Column(Name = "SRCSYSTP", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string SourceOfResponseTypeId { get; set; }
		[Column(Name = "SRCSYSCL", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string SourceofResponseClassType { get; set; }
		[Column(Name = "ANSWR1", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long Lvl1Answer { get; set; }
		[Column(Name = "ANSWR2", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long Lvl2Answer { get; set; }
		[Column(Name = "ANSWR3", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long Lvl3Answer { get; set; }
		[Column(Name = "COMMENTS", DataType = DataType.Char, CanBeNull = false, Length = 1000)]
		public string Comments { get; set; }
		[Column(Name = "USRID1", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string UserOfLastUpdate { get; set; }
		[Column(Name = "BRNCHID", DataType = DataType.Char, CanBeNull = false, Length = 4)]
		public string ResponceUnit { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
		[Column(Name = "CR1C3ZA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string SourceLastModified { get; set; }
		[Column(Name = "CR1C40A", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string UserNextAction { get; set; }
		[Column(Name = "CR1C41A", DataType = DataType.Char, CanBeNull = false, Length = 4)]
		public string BranchNextAction { get; set; }
		[Column(Name = "CR1C42A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string SourceNextAction { get; set; }
		[Column(Name = "CR9UA", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string HistoricStatus { get; set; }
		[Column(Name = "ACTNUSR", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string UserOfAction { get; set; }
		[Column(Name = "ACTNBRN", DataType = DataType.Char, CanBeNull = false, Length = 4)]
		public string BranchOfAction { get; set; }
	}
}
