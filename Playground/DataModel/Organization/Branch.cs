using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Organization
{
	[Table(Name = "CRS46P", Schema = "XCRS")]
	public partial class Branch
	{
		[Column(IsPrimaryKey = true, Name = "IPIDCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int IpId { get; set; }
		[Column(Name = "CRS2A", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string OrgUnitName { get; set; }
		[Column(Name = "CRS3A", DataType = DataType.Char, CanBeNull = false, Length = 4)]
		public string BranchIdMnem { get; set; }
		[Column(Name = "CRS4A", DataType = DataType.Char, CanBeNull = false, Length = 4)]
		public string BranchIdNum { get; set; }
		[Column(Name = "CRS5A", DataType = DataType.Char, CanBeNull = false, Length = 2)]
		public string OrgUnitLcStatus { get; set; }
		[Column(Name = "CR8LA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string TypeTypeId { get; set; }
		[Column(Name = "CREIA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string TypeClassType { get; set; }
		[Column(Name = "CRS6A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string AccDesignTypeTypeId { get; set; }
		[Column(Name = "CRS7A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string AccDesignTypeClassType { get; set; }
		[Column(Name = "CRS8A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string FnctnTypeTypeId { get; set; }
		[Column(Name = "CRS9A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string FnctnTypeClassType { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
