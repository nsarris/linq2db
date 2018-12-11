using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Calendar
{
	[Table(Name = "CALEVEPF", Schema = "XCRS")]
	public partial class CalendarEvent
	{
		[Column(IsPrimaryKey = true, Name = "CALEVEID", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int Id { get; set; }
		[Column(Name = "EXCHITEM", DataType = DataType.Char, CanBeNull = false, Length = 200)]
		public string ExchangeItemId { get; set; }
		[Column(Name = "CALEVSRC", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string Source { get; set; }
		[Column(Name = "CALEVTID", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int CalendarEventTypeId { get; set; }
		[Column(Name = "CALEVESTD", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string StatusTypeId { get; set; }
		[Column(Name = "CALEVECT", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string StatusClassType { get; set; }
		[Column(Name = "CALEVSTM", DataType = DataType.DateTime2, CanBeNull = false)]
		public DateTime StartTime { get; set; }
		[Column(Name = "CALEVETM", DataType = DataType.DateTime2, CanBeNull = false)]
		public DateTime EndTime { get; set; }
		[Column(Name = "CALEVSUB", DataType = DataType.Char, CanBeNull = false, Length = 500)]
		public string Subject { get; set; }
		[Column(Name = "CALEVCOM", DataType = DataType.Char, CanBeNull = false, Length = 1000)]
		public string Comments { get; set; }
		[Column(Name = "CALEVORG", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string Origin { get; set; }
		[Column(Name = "CALEVOLM", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string OriginLastModified { get; set; }
		[Column(Name = "CALEVELA", DataType = DataType.Char, CanBeNull = false, Length = 1000)]
		public string LocationAddress { get; set; }
		[Column(Name = "CALEVONP", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsOnPremises { get; set; }
		[Column(Name = "CALEVCDX", DataType = DataType.Decimal, CanBeNull = false, Precision = 12, Scale = 9)]
		public decimal LocationCordX { get; set; }
		[Column(Name = "CALEVCDY", DataType = DataType.Decimal, CanBeNull = false, Precision = 12, Scale = 9)]
		public decimal LocationCordY { get; set; }
		[Column(Name = "CALEVIMP", DataType = DataType.Int16, CanBeNull = false, Precision = 2, Scale = 0)]
		public short Importance { get; set; }
		[Column(Name = "CALEVDAY", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsAllDayEvent { get; set; }
		[Column(Name = "CALEVDCR", DataType = DataType.DateTime2, CanBeNull = false)]
		public DateTime DateCreated { get; set; }
		[Column(Name = "CALEVNME", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string LastmModificationUser { get; set; }
		[Column(Name = "CALEVLMT", DataType = DataType.DateTime2, CanBeNull = false)]
		public DateTime LastModificationTime { get; set; }
		[Column(Name = "CALEVVSR", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int VersionSource { get; set; }
		[Column(Name = "CALEVERS", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int Version { get; set; }
		[Column(Name = "CALEVOWN", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string Creator { get; set; }
		[Column(Name = "CALEVATT", DataType = DataType.Char, CanBeNull = false, Length = 2000)]
		public string Attachment { get; set; }
		[Column(Name = "CALEVREO", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short Reccurence { get; set; }
		[Column(Name = "CALEVCID", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int CalendarId { get; set; }
		[Column(Name = "CALEVRID", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int ReminderId { get; set; }
		[Column(Name = "CPRTEXID", DataType = DataType.Char, CanBeNull = false, Length = 200)]
		public string ParentExchangeId { get; set; }
		[Column(Name = "CRECUSTD", DataType = DataType.DateTime2, CanBeNull = false)]
		public DateTime ReccurenceStart { get; set; }
		[Column(Name = "CRECUEND", DataType = DataType.DateTime2, CanBeNull = false)]
		public DateTime ReccurenceEnd { get; set; }
		[Column(Name = "CRECUPAT", DataType = DataType.Char, CanBeNull = false, Length = 1000)]
		public string ReccurencePattern { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
