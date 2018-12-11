using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Activity
{
	[Table(Name = "CONTMED", Schema = "XCRS")]
	public partial class ContactMedium
	{
		[Column(Name = "CONTMDID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long Id { get; set; }
		[Column(Name = "CONTNAME", DataType = DataType.Char, CanBeNull = false, Length = 100)]
		public string Name { get; set; }
		[Column(Name = "HASDURAT", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short HasDuration { get; set; }
		[Column(Name = "USERSELC", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsUserSelectable { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
