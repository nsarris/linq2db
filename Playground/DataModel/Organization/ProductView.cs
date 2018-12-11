using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Organization
{
	[Table(Name = "IC2PDDC2", Schema = "XCRS")]
	public partial class ProductView
	{
		[Column(Name = "PDCD", DataType = DataType.Char, CanBeNull = false, Length = 7)]
		public string ProductId { get; set; }
		[Column(Name = "PDDESC", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string Description { get; set; }
		[Column(Name = "LVL", DataType = DataType.VarChar, CanBeNull = false, Length = 1)]
		public string CurrentLevel { get; set; }
		[Column(Name = "LVL1", DataType = DataType.Char, CanBeNull = false, Length = 7)]
		public string Level1 { get; set; }
	}
}
