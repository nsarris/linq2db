using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Notifications
{
	[Table(Name = "NOTTYPPF", Schema = "XCRS")]
	public partial class NotificationType
	{
		[Column(Name = "NOTTYPID", DataType = DataType.Int16, CanBeNull = false, Precision = 3, Scale = 0)]
		public short Id { get; set; }
		[Column(Name = "NOTDESCR", DataType = DataType.Char, CanBeNull = false, Length = 100)]
		public string Description { get; set; }
		[Column(Name = "NOTACTION", DataType = DataType.Char, CanBeNull = false, Length = 200)]
		public string Actions { get; set; }
		[Column(Name = "NOTPRIOR", DataType = DataType.Int16, CanBeNull = false, Precision = 2, Scale = 0)]
		public short Priority { get; set; }
	}
}
