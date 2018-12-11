using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
	[Table(Name = "VIP_IPID", Schema = "XCRS")]
	public partial class VipXCustomers
	{
		[Column(Name = "IPIDCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int IpId { get; set; }
		[Column(Name = "GROUPID", DataType = DataType.Char, CanBeNull = false, Length = 2)]
		public string GroupId { get; set; }
	}
}
