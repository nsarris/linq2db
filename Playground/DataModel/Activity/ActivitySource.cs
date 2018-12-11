using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Activity
{
	[Table(Name = "ACTORGN", Schema = "XCRS")]
	public partial class ActivitySource
	{
		[Column(IsPrimaryKey = true, Name = "ID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long Id { get; set; }
		[Column(Name = "ORGNAME", DataType = DataType.VarChar, CanBeNull = false, Length = 200)]
		public string Name { get; set; }
		[Column(Name = "ORGTITLE", DataType = DataType.VarChar, CanBeNull = false, Length = 200)]
		public string Title { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int Dtelmcra { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int Tmelmcra { get; set; }
	}
}
