using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Customer
{
	[Table(Name = "NEPF", Schema = "KFILPIR")]
	public partial class Account
	{
		[Column(Name = "NEEAN", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string ExternalAccountNumber { get; set; }
		[Column(Name = "NEAB", DataType = DataType.Char, CanBeNull = false, Length = 4)]
		public string AccountBranch { get; set; }
		[Column(Name = "NEAN", DataType = DataType.Char, CanBeNull = false, Length = 6)]
		public string BasicPartOfAccountNumber { get; set; }
		[Column(Name = "NEAS", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string AccountSuffix { get; set; }
		[Column(Name = "NEIBAN", DataType = DataType.Char, CanBeNull = false, Length = 34)]
		public string IBAN { get; set; }
	}
}
