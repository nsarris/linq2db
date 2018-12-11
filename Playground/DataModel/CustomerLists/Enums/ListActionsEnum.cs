using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiraeusBank.BI.ICE2.DAL.Databases.Core.DataModel.CustomerLists
{

    public class ListActionsRole : Attribute
    {
        public List<int> RoleIds { get; set; }

        public bool RequiresAddRemoveToPotentialRight { get; set; }
        public bool RequiresAddCreateApplicationRight { get; set; }
        public bool RequiresAccessKnowYourCustomerRight { get; set; }

        public ListActionsRole(params int[] values)
        {
            this.RoleIds = values.ToList();
        }
    }
    public enum ListActionsEnum
    {
        [ListActionsRole()]
        SendEmail = 1,
        [ListActionsRole()]
        PhoneCall = 2,
        [ListActionsRole()]
        View = 3,
        [ListActionsRole()]
        NewEvent = 4,
        [ListActionsRole()]
        AddToFavorites = 5,
        [ListActionsRole(RequiresAddRemoveToPotentialRight = true)]
        AddToPotentials = 6,
        [ListActionsRole(RequiresAddRemoveToPotentialRight = true)]
        DeleteFromPotentials = 7,
        [ListActionsRole(RequiresAddCreateApplicationRight = true)]
        AddToExisting = 8,
        [ListActionsRole(RequiresAddCreateApplicationRight = true)]
        DeleteFromExisting = 9,
        [ListActionsRole()]
        EditRMACampaign = 10,
        [ListActionsRole(RequiresAccessKnowYourCustomerRight = true)]
        OpenKnowYourCustomer = 11,
        SalesOpportunity = 12,
        GetHistoric = 13,
        SetPotentialCustomerIpId = 14,
        BankingByAppointment = 15, 
        Compare = 16,
        RefreshCustomer = 17
    }
}
