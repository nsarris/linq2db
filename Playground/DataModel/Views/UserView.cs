using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Views
{
	[Table(Name = "USRVIEWS", Schema = "XCRS")]
	public partial class UserView
	{
		[Column(IsPrimaryKey = true, Name = "ID", DataType = DataType.Int64, CanBeNull = false, Precision = 18, Scale = 0, IsIdentity = true)]
		public long Id { get; set; }
		[Column(Name = "LISTID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long ListId { get; set; }
		[Column(Name = "SUBLISTID", DataType = DataType.Char, CanBeNull = false, Length = 100)]
		public string SublistId { get; set; }
		[Column(Name = "NAME", DataType = DataType.Char, CanBeNull = false, Length = 1000)]
		public string Name { get; set; }
		[Column(Name = "USERID", DataType = DataType.Char, CanBeNull = false, Length = 10)]
		public string UserId { get; set; }
		[Column(Name = "ISDEFAULT", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsDefault { get; set; }
		[Column(Name = "PRIORITY", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long Priority { get; set; }
		[Column(Name = "LSTSELDATE", DataType = DataType.DateTime2, CanBeNull = false)]
		public DateTime LastSelectionDate { get; set; }
	}
}
