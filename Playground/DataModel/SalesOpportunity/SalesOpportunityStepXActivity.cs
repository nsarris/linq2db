using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.SalesOpportunity
{
	[Table(Name = "RELACTPF", Schema = "XCRS")]
	public partial class SalesOpportunityStepXActivity
	{
		[Column(IsPrimaryKey = true, Name = "ACTIVID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long ActivityId { get; set; }
		[Column(Name = "ACTPURID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long OpportunityStepId { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
