using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
	[Table(Name = "COLLTYPEPF ", Schema = "XCRS")]
	public partial class CollateralType
	{
		[Column(Name = "TYPE", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string Id { get; set; }
		[Column(Name = "NAME", DataType = DataType.Char, CanBeNull = false, Length = 70)]
		public string Description { get; set; }
		[Column(Name = "DANGERTYPE", DataType = DataType.Char, CanBeNull = false, Length = 6)]
		public string DangerType { get; set; }
		[Column(Name = "DANGERTYPEDESC", DataType = DataType.VarChar, CanBeNull = false, Length = 2)]
		public string DangerDescription { get; set; }
	}
}
