using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Arrangement
{
	[Table(Name = "CRS13P", Schema = "XCRS")]
	public partial class ArrangementExtraRelationship
	{
		[Column(Name = "IPIDCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int IpId { get; set; }
		[Column(Name = "CR6FA", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long ArrangementId { get; set; }
		[Column(Name = "CR1D4A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string RelationshipTypeId { get; set; }
		[Column(Name = "CR1D5A", DataType = DataType.Char, CanBeNull = false, Length = 3)]
		public string RelationshipClassType { get; set; }
		[Column(Name = "CR6GA", DataType = DataType.Char, CanBeNull = false, Length = 80)]
		public string Description { get; set; }
		[Column(Name = "CR1C6A", DataType = DataType.Int16, CanBeNull = false, Precision = 3, Scale = 0)]
		public short RelationshipSequence { get; set; }
		[Column(Name = "CR9SA", DataType = DataType.Date, CanBeNull = false)]
		public DateTime EffectiveDate { get; set; }
		[Column(Name = "CR9TA", DataType = DataType.Date, CanBeNull = false)]
		public DateTime EndDate { get; set; }
		[Column(Name = "CR9UA", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string HistoricalStatus { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
