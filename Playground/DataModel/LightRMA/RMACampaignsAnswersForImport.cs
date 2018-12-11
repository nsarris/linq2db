using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.LightRMA
{
	[Table(Name = "ANSIMPPF", Schema = "XCRS")]
	public partial class RMACampaignsAnswersForImport
	{
		[Column(Name = "SBCMPID", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string CampaignId { get; set; }
		[Column(Name = "SBOFFID", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string OfferId { get; set; }
		[Column(Name = "SBTRTID", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string TreatmentId { get; set; }
		[Column(Name = "EXTKEY", DataType = DataType.Char, CanBeNull = false, Length = 150)]
		public string ExternalSystemKey { get; set; }
		[Column(Name = "PEXTKEY", DataType = DataType.Char, CanBeNull = false, Length = 150)]
		public string ParentExternalSystemKey { get; set; }
		[Column(Name = "ANSDESC", DataType = DataType.Char, CanBeNull = false, Length = 150)]
		public string Description { get; set; }
		[Column(Name = "ANSCMNT", DataType = DataType.Char, CanBeNull = false, Length = 500)]
		public string Comments { get; set; }
		[Column(Name = "ANSIFIN", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsFinal { get; set; }
		[Column(Name = "ANSIFNC", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short ClosesCsa { get; set; }
		[Column(Name = "ANSCMNFL", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short CommentsMandatory { get; set; }
		[Column(Name = "ANSOTDT", DataType = DataType.Char, CanBeNull = false, Length = 1000)]
		public string Metadata { get; set; }
		[Column(Name = "CR142MA", DataType = DataType.Char, CanBeNull = false, Length = 7)]
		public string Message { get; set; }
		[Column(Name = "CR1B5MA", DataType = DataType.Char, CanBeNull = false, Length = 1)]
		public string Severity { get; set; }
		[Column(Name = "CR1AFWA", DataType = DataType.Char, CanBeNull = false, Length = 75)]
		public string MessageDescription { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
