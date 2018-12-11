using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.SalesOpportunity
{
	[Table(Name = "SALSTPPF", Schema = "XCRS")]
	public partial class SalesOpportunityStep
	{
		[Column(IsPrimaryKey = true, Name = "SALSTPID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long Id { get; set; }
		[Column(IsPrimaryKey = true, Name = "IDSALEOP", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long SalesOpportunityId { get; set; }
		[Column(Name = "SALCUSRES", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short CustomerResponse { get; set; }
		[Column(Name = "SALSTAID", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short StepStateId { get; set; }
		[Column(Name = "SALCRTTMS", DataType = DataType.DateTime2, CanBeNull = false)]
		public DateTime ContactDateStart { get; set; }
		[Column(Name = "SALENDTMS", DataType = DataType.DateTime2, CanBeNull = false)]
		public DateTime ContactDateEnd { get; set; }
		[Column(Name = "SALLSTRE", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsLatestResponse { get; set; }
		[Column(Name = "SALNXTSC", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsNextScheduled { get; set; }
		[Column(Name = "CREATOWN", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string CreatorOwner { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
