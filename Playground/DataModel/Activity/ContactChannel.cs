using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Activity
{
	[Table(Name = "CONTCHAN", Schema = "XCRS")]
	public partial class ContactChannel
	{
		[Column(IsPrimaryKey = true, Name = "CHANID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long Id { get; set; }
		[Column(Name = "CHNAME", DataType = DataType.VarChar, CanBeNull = false, Length = 200)]
		public string Name { get; set; }
		[Column(Name = "CHNTITLE", DataType = DataType.VarChar, CanBeNull = false, Length = 200)]
		public string Title { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int Dtelmcra { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int Tmelmcra { get; set; }
	}
}
