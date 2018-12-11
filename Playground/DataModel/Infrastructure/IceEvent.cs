using LinqToDB.Mapping;
using System;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.Infrastructure
{
    [Table(Name = "IC2EVEPF", Schema = "XCRS")]
    public partial class IceEvent
    {
        [Column(IsPrimaryKey = true, Name = "CR1CWWA", DataType = LinqToDB.DataType.Char, CanBeNull = false)]
        public string TopicName { get; set; }
        [Column(IsPrimaryKey = true, Name = "CR1CWXA", DataType = LinqToDB.DataType.Char, CanBeNull = false)]
        public string EventAsJson { get; set; }
        [Column(IsPrimaryKey = true, Name = "CR1CWYA", DataType = LinqToDB.DataType.DateTime, CanBeNull = false)]
        public DateTime StartTime { get; set; }
        [Column(IsPrimaryKey = true, Name = "CR1CWZA", DataType = LinqToDB.DataType.DateTime, CanBeNull = false)]
        public DateTime EndTime { get; set; }
        [Column(Name = "CR1CX0A", DataType = LinqToDB.DataType.Char, CanBeNull = true)]
        public string IsSent { get; set; }
    }
}