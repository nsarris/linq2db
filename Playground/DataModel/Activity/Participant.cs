using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LinqToDB;
using LinqToDB.Mapping;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Activity
{
	[Table(Name = "ACTVPART", Schema = "XCRS")]
	public partial class Participant
	{
		[Column(IsPrimaryKey = true, Name = "PRTCPID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long Id { get; set; }
		[Column(Name = "ENTITYID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long EntityId { get; set; }
		[Column(Name = "ACTYPEID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long ParticipantTypeId { get; set; }
		[Column(Name = "ACTIVID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long ActivityId { get; set; }
		[Column(Name = "CISREQUI", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsRequired { get; set; }
		[Column(Name = "CR14CRA", DataType = DataType.Char, CanBeNull = false, Length = 50)]
		public string Email { get; set; }
		[Column(Name = "DISPNAME", DataType = DataType.Char, CanBeNull = false, Length = 100)]
		public string DisplayName { get; set; }
		[Column(Name = "MAINPART", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsMainParticipant { get; set; }
		[Column(Name = "ISOWNER", DataType = DataType.Int16, CanBeNull = false, Precision = 1, Scale = 0)]
		public short IsOwner { get; set; }
		[Column(Name = "INVISTAT", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long InvitationStatusId { get; set; }
		[Column(Name = "REFPARTID", DataType = DataType.Int64, CanBeNull = false, Precision = 11, Scale = 0)]
		public long RelatedParticipantIpId { get; set; }
		[Column(Name = "DTELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 8, Scale = 0)]
		public int DateLastModified { get; set; }
		[Column(Name = "TMELMCRA", DataType = DataType.Int32, CanBeNull = false, Precision = 6, Scale = 0)]
		public int TimeLastModified { get; set; }
	}
}
