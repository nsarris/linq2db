using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.SalesOpportunity
{
	[Table(Name = "SALESOPPMD", Schema = "XCRS")]
	public partial class SalesOpportunityMetadata
	{
		[Column(IsPrimaryKey = true, Name = "SALOPPIP", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long SalesOpportunityStepId { get; set; }
		[Column(Name = "COMMENTS", DataType = DataType.Char, CanBeNull = true, Length = 10000)]
		public string Comments { get; set; }
	}
}
