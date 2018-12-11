using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Exchange
{
	[Table(Name = "EXCSYNCST", Schema = "XCRS")]
	public partial class ExchangeSyncState
	{
		[Column(IsPrimaryKey = true, Name = "MAILBOX", DataType = DataType.Char, CanBeNull = false, Length = 150)]
		public string Mailbox { get; set; }
		[Column(Name = "FOLDER", DataType = DataType.Char, CanBeNull = false, Length = 250)]
		public string FolderName { get; set; }
		[Column(Name = "SYNCSTATE", DataType = DataType.VarChar, CanBeNull = true, Length = 500000)]
		public string SyncState { get; set; }
		[Column(Name = "LSTSYNCST", DataType = DataType.DateTime2, CanBeNull = false)]
		public DateTime LastDateSynced { get; set; }
	}
}
