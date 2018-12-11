using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Calls
{
	[Table(Name = "CRS149P", Schema = "XCRS")]
	public partial class IncomingCall
	{
		[Column(Name = "CRSIPID", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int IpId { get; set; }
		[Column(Name = "DOMUSER", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string Username { get; set; }
		[Column(Name = "CALLDATE", DataType = DataType.Date, CanBeNull = false)]
		public DateTime DateOfCall { get; set; }
		[Column(Name = "CALLTIME", DataType = DataType.Time, CanBeNull = false)]
		public DateTime TimeOfCall { get; set; }
		[Column(Name = "TEL", DataType = DataType.Char, CanBeNull = false, Length = 15)]
		public string Phone { get; set; }
		[Column(Name = "FULNMECA", DataType = DataType.Char, CanBeNull = false, Length = 120)]
		public string CustomerDisplayName { get; set; }
		[Column(Name = "DUBRANID", DataType = DataType.Char, CanBeNull = false, Length = 4)]
		public string BranchId { get; set; }
	}
}
