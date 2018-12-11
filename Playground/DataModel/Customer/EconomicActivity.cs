using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
	[Table(Name = "CRS25P", Schema = "XCRS")]
	public partial class EconomicActivity
	{
		[Column(IsPrimaryKey = true, Name = "CRWNA", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long IndsClassId { get; set; }
		[Column(Name = "INDCLLCRA", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IndsclLevel { get; set; }
		[Column(Name = "CRWOA", DataType = DataType.Char, CanBeNull = false, Length = 120)]
		public string IndsDesc { get; set; }
		[Column(Name = "CRWPA", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long ParentIndsClassId { get; set; }
		[Column(Name = "EQ3CA2", DataType = DataType.Char, CanBeNull = false, Length = 2)]
		public string Eq3AnalysisCode { get; set; }
		[Column(Name = "CR5XEA", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string FlagAtEp { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
