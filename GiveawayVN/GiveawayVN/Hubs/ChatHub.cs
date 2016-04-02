using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace GiveawayVN
{
    public class ChatHub : Hub
    {

        public void Send(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message);
        }

        public void SendOffer(string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.SendOfferToClient(message);
        }

        public void addGroup(string connectionId)
        {
            Groups.Add(connectionId, "steambot");
        }
    }
}