using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Calendar
{
	[Table(Name = "CEPARTPF", Schema = "XCRS")]
	public partial class CalendarEventParticipant
	{
		[Column(Name = "PARTICID", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int ParticipantId { get; set; }
		[Column(Name = "CALEVEID", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int CalendarEventId { get; set; }
		[Column(Name = "CENTIID", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int EntityId { get; set; }
		[Column(Name = "CENTPEID", DataType = DataType.Int16, CanBeNull = false, Precision = 2, Scale = 0)]
		public short EntityTypeId { get; set; }
		[Column(Name = "CISOPTIO", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsOptional { get; set; }
		[Column(Name = "CISREQUI", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsRequired { get; set; }
		[Column(Name = "CEVEMAIL", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string EmailAddress { get; set; }
		[Column(Name = "CDISPLNM", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string DisplayName { get; set; }
		[Column(Name = "CISMAINP", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsMain { get; set; }
		[Column(Name = "EVEISOWN", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsOwner { get; set; }
		[Column(Name = "EVEINVSTS", DataType = DataType.Char, CanBeNull = false, Length = 20)]
		public string InvitationStatus { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
