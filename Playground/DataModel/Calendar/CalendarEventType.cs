using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Calendar
{
	[Table(Name = "CEVENTPF", Schema = "XCRS")]
	public partial class CalendarEventType
	{
		[Column(IsPrimaryKey = true, Name = "CALEVTID", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int CalendarEventTypeId { get; set; }
		[Column(Name = "CALEVNAM", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string Name { get; set; }
		[Column(Name = "CALEVHML", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short HasmandatoryLocation { get; set; }
		[Column(Name = "CALEVPHO", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsPhoneEvent { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
