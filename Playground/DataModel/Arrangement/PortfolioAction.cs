using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
	[Table(Name = "CRS159P", Schema = "XCRS")]
	public partial class PortfolioAction
	{
		[Column(Name = "DYNMNUID", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DynmenuId { get; set; }
		[Column(Name = "DYNMNULV", DataType = DataType.Int32, CanBeNull = false, Precision = 7, Scale = 0)]
		public int DynmenuLevel { get; set; }
		[Column(Name = "DYNMNUDE", DataType = DataType.Char, CanBeNull = false, Length = 100)]
		public string DynmenuDescription { get; set; }
		[Column(Name = "DISPPRIORI", DataType = DataType.Int16, CanBeNull = false, Precision = 3, Scale = 0)]
		public short Displaypriority { get; set; }
		[Column(Name = "CLASEXTSYF", DataType = DataType.Char, CanBeNull = false, Length = 100)]
		public string Classexternalsystemsfilter { get; set; }
		[Column(Name = "PDIDSINCF", DataType = DataType.Char, CanBeNull = false, Length = 100)]
		public string Includedproductidsfilter { get; set; }
		[Column(Name = "PDIDSEXCF", DataType = DataType.Char, CanBeNull = false, Length = 100)]
		public string Excludedproductidsfilter { get; set; }
		[Column(Name = "ASACTIOTYP", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string Arsactiontype { get; set; }
		[Column(Name = "VLFBUSOBJ", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string Vlfbusinessobject { get; set; }
		[Column(Name = "VLFCOMMAND", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string Vlfcommand { get; set; }
		[Column(Name = "CLAWEUTP", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ClassWebUrlsType { get; set; }
		[Column(Name = "FNCINMCRA", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string FunctionImplNme { get; set; }
		[Column(Name = "PDYMNUID", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int ParentdynmenuId { get; set; }
		[Column(Name = "CLARIPRF", DataType = DataType.Char, CanBeNull = false, Length = 100)]
		public string Clariprf { get; set; }
	}
}
