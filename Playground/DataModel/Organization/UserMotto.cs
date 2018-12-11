using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Organization
{
	[Table(Name = "ICE2MOTO", Schema = "XCRS")]
	public partial class UserMotto
	{
		[Column(Name = "MOTOID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long Id { get; set; }
		[Column(Name = "MOTOMESG", DataType = DataType.Char, CanBeNull = false, Length = 500)]
		public string Message { get; set; }
		[Column(Name = "MOTOAUTH", DataType = DataType.Char, CanBeNull = false, Length = 100)]
		public string Author { get; set; }
		[Column(Name = "MOTODTME", DataType = DataType.Char, CanBeNull = false, Length = 100)]
		public string AuthorLifeTimeData { get; set; }
	}
}
