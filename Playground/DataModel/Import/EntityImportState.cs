using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Import
{
	[Table(Name = "IMPENTST", Schema = "XCRS")]
	public partial class EntityImportState
	{
		[Column(Name = "IMPENTID", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string EntityId { get; set; }
		[Column(Name = "IMPENTYP", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string EntityType { get; set; }
	}
}
