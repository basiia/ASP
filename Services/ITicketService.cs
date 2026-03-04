using System.Collections.Generic;

public interface ITicketService
{
	List<Ticket> GetAllTickets(); 
	void AddTicket(Ticket ticket);
}

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