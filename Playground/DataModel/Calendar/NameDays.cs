using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Calendar
{
	[Table(Name = "EORTESIC2", Schema = "XCRS")]
	public partial class NameDays
	{
		[Column(Name = "NAME", DataType = DataType.Char, CanBeNull = false, Length = 45)]
		public string Name { get; set; }
		[Column(Name = "DAY", DataType = DataType.Int16, CanBeNull = false, Precision = 2, Scale = 0)]
		public short Day { get; set; }
		[Column(Name = "MONTH", DataType = DataType.Int16, CanBeNull = false, Precision = 2, Scale = 0)]
		public short Month { get; set; }
	}
}
