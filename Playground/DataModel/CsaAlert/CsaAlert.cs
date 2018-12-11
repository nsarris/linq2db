using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel
{
	[Table(Name = "ALERTPFIC2 ", Schema = "XCRS")]
	public partial class CsaAlert
	{
		[Column(IsPrimaryKey = true, Name = "CSAALRID", DataType = DataType.Decimal, CanBeNull = false, Precision = 11, Scale = 0)]
		public long AlertId { get; set; }
		[Column(Name = "ALRTID", DataType = DataType.Decimal, CanBeNull = false, Precision = 12, Scale = 0)]
		public long AlertIdCmr { get; set; }
		[Column(Name = "IPIDCRA", DataType = DataType.Decimal, CanBeNull = false, Precision = 8, Scale = 0)]
		public int CrsId { get; set; }
		[Column(Name = "CFULLNAME", DataType = DataType.Char, CanBeNull = false, Length = 35)]
		public string CustomerFullName { get; set; }
		[Column(Name = "TRIGDATE", DataType = DataType.Date, CanBeNull = false)]
		public DateTime TriggerDate { get; set; }
		[Column(Name = "TRIGTIME", DataType = DataType.Decimal, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TriggerTime { get; set; }
		[Column(Name = "TRANID", DataType = DataType.Decimal, CanBeNull = false, Precision = 7, Scale = 0)]
		public int TransactionId { get; set; }
		[Column(Name = "TRANDESC", DataType = DataType.Char, CanBeNull = false, Length = 35)]
		public string TransactionDescription { get; set; }
		[Column(Name = "TRIGBR", DataType = DataType.Char, CanBeNull = false, Length = 4)]
		public string TriggeredBranch { get; set; }
		[Column(Name = "TRIGCHAN", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string TriggeredChannel { get; set; }
		[Column(Name = "TRIGUSER", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string TriggeredByUser { get; set; }
		[Column(Name = "TRIGNAME", DataType = DataType.Char, CanBeNull = false, Length = 35)]
		public string TriggeredByName { get; set; }
		[Column(Name = "CONTACTED", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string Contacted { get; set; }
		[Column(Name = "CONTUSER", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string ContactedUser { get; set; }
		[Column(Name = "CONTDATE", DataType = DataType.Date, CanBeNull = false)]
		public DateTime ContactedDate { get; set; }
		[Column(Name = "CONTTIME", DataType = DataType.Decimal, CanBeNull = false, Precision = 6, Scale = 0)]
		public int ContactedTime { get; set; }
		[Column(Name = "CR1C46A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string Status1TypeId { get; set; }
		[Column(Name = "CR1C47A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string Status1ClassType { get; set; }
		[Column(Name = "ALSTATUS", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string AlertStatus { get; set; }
		[Column(Name = "CR1C3UA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ListId { get; set; }
		[Column(Name = "SUBLSTID", DataType = DataType.Decimal, CanBeNull = false, Precision = 11, Scale = 0)]
		public long SublistName { get; set; }
		[Column(Name = "ANSID", DataType = DataType.Decimal, CanBeNull = false, Precision = 11, Scale = 0)]
		public long AnswerId { get; set; }
		[Column(Name = "ENDTIME", DataType = DataType.DateTime2, CanBeNull = false)]
		public DateTime AlertEndTime { get; set; }
		[Column(Name = "CAMPDESC", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string CampDescription { get; set; }
	}
}
