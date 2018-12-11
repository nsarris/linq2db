using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Activity
{
	[Table(Name = "ACTREPLQ", Schema = "XCRS")]
	public partial class ActivityReplicationQueueItem
	{
		[Column(IsPrimaryKey = true, Name = "ID", DataType = DataType.Int64, CanBeNull = false, Precision = 18, Scale = 0, IsIdentity = true)]
		public long Id { get; set; }
		[Column(Name = "ACTIVITY_ID", DataType = DataType.VarChar, CanBeNull = false, Length = 200)]
		public string ActivityId { get; set; }
		[Column(Name = "ACTION", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short Action { get; set; }
		[Column(Name = "ICECOMM", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IceCommited { get; set; }
		[Column(Name = "EXCCOMM", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short ExcCommited { get; set; }
		[Column(Name = "RMACOMM", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short RmaCommited { get; set; }
		[Column(Name = "ACTJSON", DataType = DataType.VarChar, CanBeNull = true, Length = 500000)]
		public string ActivityJson { get; set; }
		[Column(Name = "DTTIME", DataType = DataType.DateTime2, CanBeNull = false)]
		public DateTime DateTimeCreated { get; set; }
	}
}
