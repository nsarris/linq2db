using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Views
{
	[Table(Name = "USRVIEWCOL", Schema = "XCRS")]
	public partial class UserViewColumn
	{
		[Column(IsPrimaryKey = true, Name = "ID", DataType = DataType.Int64, CanBeNull = false, Precision = 18, Scale = 0, IsIdentity = true)]
		public long Id { get; set; }
		[Column(Name = "VIEWID", DataType = DataType.Int64, CanBeNull = false, Precision = 18, Scale = 0)]
		public long ViewId { get; set; }
		[Column(Name = "NAME", DataType = DataType.Char, CanBeNull = false, Length = 1000)]
		public string Name { get; set; }
		[Column(Name = "DISPCAT", DataType = DataType.Int32, CanBeNull = false, Precision = 5, Scale = 0)]
		public int DisplayCategory { get; set; }
		[Column(Name = "DISPPRT", DataType = DataType.Int32, CanBeNull = false, Precision = 5, Scale = 0)]
		public int DisplayPriority { get; set; }
		[Column(Name = "WIDTH", DataType = DataType.Int32, CanBeNull = false, Precision = 5, Scale = 0)]
		public int Width { get; set; }
		[Column(Name = "FLTRVAL", DataType = DataType.Char, CanBeNull = false, Length = 250)]
		public string FilterValue { get; set; }
		[Column(Name = "FLTRVALS", DataType = DataType.Char, CanBeNull = false, Length = 2000)]
		public string FilterValues { get; set; }
		[Column(Name = "ISASC", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public byte IsAsc { get; set; }
		[Column(Name = "SORTPRTY", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public byte SortPriority { get; set; }
	}
}
