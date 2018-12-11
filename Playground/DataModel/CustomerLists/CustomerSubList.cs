using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{
	[Table(Name = "PRMSBLPF", Schema = "XCRS")]
	public partial class CustomerSubList
	{
		[Column(Name = "CR1C3UA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ListId { get; set; }
		[Column(Name = "SUBLSTID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long SublistId { get; set; }
		[Column(Name = "CMPNAME", DataType = DataType.Char, CanBeNull = false, Length = 100)]
		public string Name { get; set; }
		[Column(Name = "CMPDESC", DataType = DataType.Char, CanBeNull = false, Length = 1000)]
		public string Description { get; set; }
		[Column(Name = "CMPSTRDT", DataType = DataType.Date, CanBeNull = false)]
		public DateTime StartDate { get; set; }
		[Column(Name = "CMPENDDT", DataType = DataType.Date, CanBeNull = false)]
		public DateTime EndDate { get; set; }
		[Column(Name = "CMPSRTP", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string SourceTypeId { get; set; }
		[Column(Name = "CMPSRCL", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string SourceClass { get; set; }
		[Column(Name = "CMPENBL", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short Enabled { get; set; }
		[Column(Name = "CMPINDTR", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsIndicator { get; set; }
		[Column(Name = "CNTRTPE", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short CounterType { get; set; }
		[Column(Name = "DRILFLG", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short Drillability { get; set; }
		[Column(Name = "CLDANFLG", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short HasHotColdAnswers { get; set; }
		[Column(Name = "DFLTFLG", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsDefaultSelected { get; set; }
		[Column(Name = "EXPDFLG", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short Expandable { get; set; }
		[Column(Name = "HISTFLG", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short HasHistory { get; set; }
		[Column(Name = "COLMFLG", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short AllowColumnChoose { get; set; }
		[Column(Name = "SVLAYFLG", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short AllowSaveLayout { get; set; }
		[Column(Name = "FFUFLG1", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short ExternalEditTypeId { get; set; }
		[Column(Name = "FFUFLG2", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short HasAutoRefresh { get; set; }
		[Column(Name = "FFUFLG3", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short AnswerSourceTypeId { get; set; }
		[Column(Name = "FFUFLG4", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short ForFutureUseFlag4 { get; set; }
		[Column(Name = "FFUFLG5", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short ForFutureUseFlag5 { get; set; }
		[Column(Name = "LSTMDUSR", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string LastModifiedUserId { get; set; }
		[Column(Name = "CMPRSPTP", DataType = DataType.Int16, CanBeNull = false, Precision = 2, Scale = 0)]
		public short ResponseType { get; set; }
		[Column(Name = "CMPKEY", DataType = DataType.Char, CanBeNull = false, Length = 100)]
		public string ExternalKey { get; set; }
		[Column(Name = "PRODLVL", DataType = DataType.Char, CanBeNull = false, Length = 7)]
		public string ProductLevel { get; set; }
		[Column(Name = "OFFNAME", DataType = DataType.Char, CanBeNull = false, Length = 250)]
		public string OfferName { get; set; }
		[Column(Name = "OFFDESC", DataType = DataType.Char, CanBeNull = false, Length = 250)]
		public string OfferDescription { get; set; }
		[Column(Name = "CMPJSN", DataType = DataType.Char, CanBeNull = false, Length = 12000)]
		public string MetaData { get; set; }
		[Column(Name = "PROPTYPE", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long Proposaltypeid { get; set; }
		[Column(Name = "PROD_ID", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int NbaProductId { get; set; }
		[Column(Name = "PROD_DESC", DataType = DataType.Char, CanBeNull = false, Length = 250)]
		public string ProductDescription { get; set; }
		[Column(Name = "ACTNTPID", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int NbaActionId { get; set; }
		[Column(Name = "ACTNDESC", DataType = DataType.Char, CanBeNull = false, Length = 250)]
		public string NbaActionDescription { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
