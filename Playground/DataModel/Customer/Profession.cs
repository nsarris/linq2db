using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
	[Table(Name = "CRS29P", Schema = "XCRS")]
	public partial class Profession
	{
		[Column(IsPrimaryKey = true, Name = "CRLCA", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long IndvOcptnTypeId { get; set; }
		[Column(Name = "INVOTLXSA", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IndvotLevel { get; set; }
		[Column(Name = "CR6GA", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string Desc { get; set; }
		[Column(Name = "CRVUA", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long ParentIndvOcptnTypeId { get; set; }
		[Column(Name = "EQ3CA2", DataType = DataType.Char, CanBeNull = false, Length = 2)]
		public string Eq3Analysiscode { get; set; }
		[Column(Name = "CR5XEA", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string FlagAtEp { get; set; }
		[Column(Name = "CR60EA", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string FlagEl { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
