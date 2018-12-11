using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Organization
{
	[Table(Name = "CRS82P", Schema = "XCRS")]
	public partial class LegalEntityType
	{
		[Column(Name = "CRCKA", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string CustomerTypeCode { get; set; }
		[Column(Name = "EQ3CUCTG", DataType = DataType.Char, CanBeNull = false, Length = 6)]
		public string Eq3CustomerCategory { get; set; }
		[Column(Name = "EQ3CTP", DataType = DataType.Char, CanBeNull = false, Length = 2)]
		public string Eq3CustomerType { get; set; }
		[Column(Name = "EQ3CTPD", DataType = DataType.Char, CanBeNull = false, Length = 35)]
		public string Eq3CustomerTypeDescription { get; set; }
	}
}
