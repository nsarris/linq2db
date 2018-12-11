using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Activity
{
	[Table(Name = "ACTIVITYMD", Schema = "XCRS")]
	public partial class ActivityMetadata
	{
		[Column(IsPrimaryKey = true, Name = "ACTIVID", DataType = DataType.Decimal, CanBeNull = false, Precision = 11, Scale = 0)]
		public long ActivityId { get; set; }
		[Column(Name = "SUBJECT", DataType = DataType.Char, CanBeNull = true, Length = 10000)]
		public string Subject { get; set; }
		[Column(Name = "MSGBODY", DataType = DataType.Char, CanBeNull = true, Length = 10000)]
		public string MessageBody { get; set; }
		[Column(Name = "COMMENTS", DataType = DataType.Char, CanBeNull = true, Length = 10000)]
		public string Comments { get; set; }
	}
}
