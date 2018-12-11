using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Organization
{
	[Table(Name = "IC2PDSOP", Schema = "XCRS")]
	public partial class Product
	{
		[Column(Name = "PDCD", DataType = DataType.Char, CanBeNull = false, Length = 11)]
		public string ProductId { get; set; }
		[Column(Name = "PDDESC", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string Description { get; set; }
		[Column(Name = "LVL", DataType = DataType.Int32, CanBeNull = false, Precision = 7, Scale = 0)]
		public int CurrentLevel { get; set; }
		[Column(Name = "LVL1", DataType = DataType.Char, CanBeNull = false, Length = 7)]
		public string Level1ProductId { get; set; }
		[Column(Name = "LVL1DESC", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string Level1ProductDescription { get; set; }
		[Column(Name = "LVL3", DataType = DataType.Char, CanBeNull = false, Length = 7)]
		public string Level3ProductId { get; set; }
		[Column(Name = "LVL3DESC", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string Level3ProductDescription { get; set; }
		[Column(Name = "LVL4", DataType = DataType.Char, CanBeNull = false, Length = 7)]
		public string Level4ProductId { get; set; }
		[Column(Name = "LVL4DESC", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string Level4ProductDescription { get; set; }
		[Column(Name = "LVL5", DataType = DataType.Char, CanBeNull = false, Length = 7)]
		public string Level5ProductId { get; set; }
		[Column(Name = "LVL5DESC", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string Level5ProductDescription { get; set; }
	}
}
