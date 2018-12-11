using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Notifications
{
	[Table(Name = "NOTUSRPF", Schema = "XCRS")]
	public partial class UserNotification
	{
		[Column(Name = "IDNOTIF", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long Id { get; set; }
		[Column(Name = "NOTTYPID", DataType = DataType.Int16, CanBeNull = false, Precision = 3, Scale = 0)]
		public short TypeId { get; set; }
		[Column(Name = "NOTTITLE", DataType = DataType.Char, CanBeNull = false, Length = 100)]
		public string Title { get; set; }
		[Column(Name = "NOTTEXT", DataType = DataType.Char, CanBeNull = false, Length = 1000)]
		public string Text { get; set; }
		[Column(Name = "NOTMETD", DataType = DataType.Char, CanBeNull = false, Length = 1000)]
		public string Metadata { get; set; }
		[Column(Name = "NOTIPID", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int Ipid { get; set; }
		[Column(Name = "USCRECRA", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string Username { get; set; }
		[Column(Name = "NOTREFID", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string ReferenceId { get; set; }
		[Column(Name = "NOTRSTATE", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short ReadState { get; set; }
		[Column(Name = "NOTCRTTMS", DataType = DataType.DateTime2, CanBeNull = false)]
		public DateTime CreationTimestamp { get; set; }
		[Column(Name = "NOTKNOTMS", DataType = DataType.DateTime2, CanBeNull = false)]
		public DateTime AcknowledgeTimestamp { get; set; }
		[Column(Name = "NOTEXPTMS", DataType = DataType.DateTime2, CanBeNull = false)]
		public DateTime ExpirationTimestamp { get; set; }
		[Column(Name = "NOTSRCID", DataType = DataType.Char, CanBeNull = false, Length = 100)]
		public string SourceId { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
