using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel
{
	[Table(Name = "CRS55X", Schema = "XCRS")]
	public partial class ClassificationExtension
	{
		[Column(Name = "CR9OA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string TypeId { get; set; }
		[Column(Name = "CR9QA", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string ClassType { get; set; }
		[Column(Name = "DTAITEM", DataType = DataType.Char, CanBeNull = false, Length = 2048)]
		public string Description { get; set; }
	}
}
