using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Calendar
{
	[Table(Name = "CALENDPF", Schema = "XCRS")]
	public partial class UserCalendar
	{
		[Column(Name = "CALTYPID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long Id { get; set; }
		[Column(Name = "REQUSER", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string UserId { get; set; }
		[Column(Name = "CALENAME", DataType = DataType.Char, CanBeNull = false, Length = 100)]
		public string Name { get; set; }
		[Column(Name = "CALTPCOL", DataType = DataType.Char, CanBeNull = false, Length = 6)]
		public string Color { get; set; }
		[Column(Name = "CALISDEF", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsDefault { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
