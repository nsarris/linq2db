using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Organization
{
	[Table(Name = "VIP_USAC", Schema = "XCRS")]
	public partial class VipXUsers
	{
		[Column(Name = "CRBJA", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string UserId { get; set; }
		[Column(Name = "GROUPID", DataType = DataType.Char, CanBeNull = false, Length = 2)]
		public string GroupId { get; set; }
	}
}
