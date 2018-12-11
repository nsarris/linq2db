using LinqToDB;
using LinqToDB.Data;
using LinqToDB.Mapping;
using PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.SalesOpportunity;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Playground
{
	class Program
	{
		static async Task Main(string[] args)
		{
			DataConnection.OnTrace = Trace;
			var traceSwitch = new TraceSwitch("test", "test");
			traceSwitch.Level = TraceLevel.Verbose;
			DataConnection.TraceSwitch = traceSwitch;
			LinqToDB.Common.Configuration.Linq.AllowMultipleQuery = true;

			await TestQuery();
			//await TestQuery();
		}


		static async Task<int> TestQuery()
		{
			var provider = new LinqToDB.DataProvider.DB2.DB2DataProvider("DB2iSeriesDataProvider", LinqToDB.DataProvider.DB2.DB2Version.i);
			using (var con = new DataConnection(provider, "Database = ATHINA; User ID = APICE; Password = @ICE3SERV; Server = athina.piraeusbank.gr:446;"))
			{
				var t = con.GetTable<SalesOpportunity>();
				var l = 
					await t
					.Where(x => x.Creator == "XQ91" || x.UserLastModified == "XQ91")
					.Select(x => new
				{
					Opportunity = new
					{
						x.Id,
						x.IsActive,
						x.IsDeleted,
						x.IpId,
						x.ProductLevel,
						x.ProductId,
						x.Amount,
						x.Creator,
						x.DateCreated,
						x.TimeCreated,
						x.UserLastModified,
						x.DateLastModified,
						x.TimeLastModified
					},
					Steps = x.Steps
									//.OrderBy(s => s.Id)
									.Select(step => new
									{
										step.Id,
										step.CustomerResponse,
										StepState = step.StepStateId,
										step.Metadata.Comments,
										step.CreatorOwner,
										SalesOpportunityActivity = new
										{
											step.OpportunityStepXActivity.ActivityId,
											ContactMediumId = (int)step.OpportunityStepXActivity.Activity.ContactMediumId,
											step.OpportunityStepXActivity.Activity.StartTime,
											step.OpportunityStepXActivity.Activity.EndTime,
											Participants = step.OpportunityStepXActivity.Activity.Participants
												.Select(p => new
												{
													p.Id,
													p.EntityId,
													ParticipantType = p.ParticipantTypeId,
													IsRequired = p.IsRequired != 0,
													p.Email,
													p.DisplayName,
													p.RelatedParticipantIpId,
													p.IsOwner,
													p.IsMainParticipant
												}).ToList()
										}
									}).ToList()
				})
							.ToListAsync();

				return l.Count;
			}

			
		}


		static void Trace(TraceInfo traceInfo)
		{
			Debug.WriteLine(traceInfo.TraceInfoStep.ToString() + " : " + traceInfo.ExecutionTime.ToString());
		}
	}
}
