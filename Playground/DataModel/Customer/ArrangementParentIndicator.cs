using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
	[Table(Name = "CRS13TC", Schema = "XCRS")]
	public partial class ArrangementParentIndicator
	{
		[Column(Name = "CR4OSA", DataType = DataType.Char, CanBeNull = false, Length = 25)]
		public string Username { get; set; }
		[Column(Name = "PDLVL1CD", DataType = DataType.Char, CanBeNull = false, Length = 7)]
		public string ProductLevel1 { get; set; }
		[Column(Name = "PDLVL2CD", DataType = DataType.Char, CanBeNull = false, Length = 7)]
		public string ProductLevel2 { get; set; }
		[Column(Name = "PDLVL3CD", DataType = DataType.Char, CanBeNull = false, Length = 7)]
		public string ProductLevel3 { get; set; }
		[Column(Name = "GRPIPID", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int GroupsIpId { get; set; }
		[Column(Name = "PDTYCLTY", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ProductClassType { get; set; }
		[Column(Name = "IPIDCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int IpId { get; set; }
		[Column(Name = "CR6FA", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long ArrangementId { get; set; }
		[Column(Name = "ARIPCLTY", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string RelationshipClassType { get; set; }
		[Column(Name = "FLDNME", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string FieldName { get; set; }
		[Column(Name = "CUFDVALE", DataType = DataType.Char, CanBeNull = false, Length = 100)]
		public string CustomFieldValueExtended { get; set; }
	}
}
