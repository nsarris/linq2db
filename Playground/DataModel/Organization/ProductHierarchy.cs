using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Organization
{
	[Table(Name = "DWPDHRC", Schema = "XCRS")]
	public partial class ProductHierarchy
	{
		[Column(Name = "PDLVL1CD", DataType = DataType.Char, CanBeNull = false, Length = 7)]
		public string Level1ProductId { get; set; }
		[Column(Name = "PDL1DESC", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string Level1ProductDescription { get; set; }
		[Column(Name = "PDLVL2CD", DataType = DataType.Char, CanBeNull = false, Length = 7)]
		public string Level3ProductId { get; set; }
		[Column(Name = "PDL2DESC", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string Level3ProductDescription { get; set; }
		[Column(Name = "PDLVL3CD", DataType = DataType.Char, CanBeNull = false, Length = 7)]
		public string Level5ProductId { get; set; }
		[Column(Name = "PDL3DESC", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string Level5ProductDescription { get; set; }
		[Column(Name = "PDL3STS", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string Level5ProductStatus { get; set; }
		[Column(Name = "PDLVL4CD", DataType = DataType.Char, CanBeNull = false, Length = 7)]
		public string Level4ProductId { get; set; }
		[Column(Name = "PDL4DESC", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string Level4ProductDescription { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
