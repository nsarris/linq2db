using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
	[Table(Name = "COLLALLOPF ", Schema = "XCRS")]
	public partial class CollateralDetailInfo
	{
		[Column(Name = "IPIDCRA", DataType = DataType.Decimal, CanBeNull = true, Precision = 8, Scale = 0)]
		public int IpId { get; set; }
		[Column(Name = "TYPE", DataType = DataType.Char, CanBeNull = true, Length = 3)]
		public string CollateralTypeId { get; set; }
		[Column(Name = "HAIRCUT", DataType = DataType.Decimal, CanBeNull = true, Precision = 31, Scale = 2)]
		public decimal HaircutValue { get; set; }
		[Column(Name = "COVERED", DataType = DataType.Decimal, CanBeNull = true, Precision = 31, Scale = 2)]
		public decimal CoveredValue { get; set; }
	}
}
