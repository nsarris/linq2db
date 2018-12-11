using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Organization
{
	[Table(Name = "PROFINDU", Schema = "XCRS")]
	public partial class ProfessionsEconomicActivitiesUnion
	{
		[Column(Name = "CSTOCPND", DataType = DataType.Char, CanBeNull = false, Length = 12)]
		public string Id { get; set; }
		[Column(Name = "DESCR", DataType = DataType.Char, CanBeNull = false, Length = 120)]
		public string Description { get; set; }
	}
}
