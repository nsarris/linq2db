using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Activity
{
	[Table(Name = "ACTIVITY", Schema = "XCRS")]
	public partial class Activity
	{
		[Column(IsPrimaryKey = true, Name = "ACTIVID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long Id { get; set; }
		[Column(Name = "EXCHITEM", DataType = DataType.Char, CanBeNull = false, Length = 200)]
		public string ExchangeItemId { get; set; }
		[Column(Name = "CONTMDID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long ContactMediumId { get; set; }
		[Column(Name = "DIRINOUT", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short Direction { get; set; }
		[Column(Name = "CHANLID", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string ChannelId { get; set; }
		[Column(Name = "ACTSTSID", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short StatusId { get; set; }
		[Column(Name = "CNLREASON", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short CancellationReason { get; set; }
		[Column(Name = "ISDELETE", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsDeleted { get; set; }
		[Column(Name = "ACTSTRDT", DataType = DataType.DateTime2, CanBeNull = false)]
		public DateTime StartTime { get; set; }
		[Column(Name = "ACTENDDT", DataType = DataType.DateTime2, CanBeNull = false)]
		public DateTime EndTime { get; set; }
		[Column(Name = "TEXTIDS", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long TextIds { get; set; }
		[Column(Name = "ACTVSUBJ", DataType = DataType.Char, CanBeNull = false, Length = 200)]
		public string Subject { get; set; }
		[Column(Name = "UNITOFORG", DataType = DataType.Int16, CanBeNull = false, Precision = 4, Scale = 0)]
		public short OriginBranchId { get; set; }
		[Column(Name = "ACTORGID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long OriginId { get; set; }
		[Column(Name = "ACTSRCID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long SourceId { get; set; }
		[Column(Name = "SRCREFID", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string SourceReferenceId { get; set; }
		[Column(Name = "BUSPRCID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long BusinessProcessId { get; set; }
		[Column(Name = "ONPREMIS", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short OnPremises { get; set; }
		[Column(Name = "LOCXACT", DataType = DataType.Decimal, CanBeNull = false, Precision = 12, Scale = 9)]
		public decimal LocationCoordX { get; set; }
		[Column(Name = "LOCYACT", DataType = DataType.Decimal, CanBeNull = false, Precision = 12, Scale = 9)]
		public decimal LocationCoordY { get; set; }
		[Column(Name = "LOCATEXT", DataType = DataType.Char, CanBeNull = false, Length = 250)]
		public string LocationText { get; set; }
		[Column(Name = "CR1DXJA", DataType = DataType.Int16, CanBeNull = false, Precision = 2, Scale = 0)]
		public short Locationtype { get; set; }
		[Column(Name = "LOCBRNCH", DataType = DataType.Char, CanBeNull = false, Length = 4)]
		public string LocationBranch { get; set; }
		[Column(Name = "IMPORTAN", DataType = DataType.Int16, CanBeNull = false, Precision = 2, Scale = 0)]
		public short Importance { get; set; }
		[Column(Name = "ISDAYEVE", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsAllDayEvent { get; set; }
		[Column(Name = "VERSISRC", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long VersionSource { get; set; }
		[Column(Name = "AVERSION", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long Version { get; set; }
		[Column(Name = "RECURRCY", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsRecurrent { get; set; }
		[Column(Name = "RECSTRDT", DataType = DataType.DateTime2, CanBeNull = false)]
		public DateTime RecurrencyStartDateTime { get; set; }
		[Column(Name = "RECENDDT", DataType = DataType.DateTime2, CanBeNull = false)]
		public DateTime RecurrencyEndDateTime { get; set; }
		[Column(Name = "RECUPAT", DataType = DataType.Char, CanBeNull = false, Length = 1000)]
		public string RecurrencyPattern { get; set; }
		[Column(Name = "CALEVCID", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int CalendarId { get; set; }
		[Column(Name = "CALEVRID", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int ReminderId { get; set; }
		[Column(Name = "CPRTEXID", DataType = DataType.Char, CanBeNull = false, Length = 200)]
		public string ParentExchangeItemId { get; set; }
		[Column(Name = "IPIDCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int IpId { get; set; }
		[Column(Name = "USROWNER", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string Owner { get; set; }
		[Column(Name = "USERCREA", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string Creator { get; set; }
		[Column(Name = "USRLSTMD", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string UserLastModified { get; set; }
		[Column(Name = "DTMCREAT", DataType = DataType.DateTime2, CanBeNull = false)]
		public DateTime DateTimeCreated { get; set; }
		[Column(Name = "DTMLSTMD", DataType = DataType.DateTime2, CanBeNull = false)]
		public DateTime DateTimeLastModified { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
