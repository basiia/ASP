using System.Collections.Generic;
using UniDesk.Web.Models; 

namespace UniDesk.Web.Services
{
	public class InMemoryTicketService : ITicketService
	{
		private List<Ticket> tickets = new List<Ticket>();

		public List<Ticket> GetAllTickets()
		{
			return tickets; 
		}

		public void AddTicket(Ticket ticket)
		{
			tickets.Add(ticket); 
		}
	}
}