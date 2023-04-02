using TicketSystem.DAL.Entities;
using Bogus;

namespace TicketSystem.DAL
{
    public class SeederDb
    {
        private readonly DatabaseContext _context;

        public SeederDb(DatabaseContext context)
        {
            _context = context;
        }

        public async Task SeederAsync()
        {
            await _context.Database.EnsureCreatedAsync();
            await PopulateTicketsAsync();
        }

        private async Task PopulateTicketsAsync()
        {
            if(!_context.Tickets.Any())
            {
                //Create some rules for the tickets
                var ticket = new Faker<Ticket>();

                var tickets = ticket.Generate(50000);

                _context.Tickets.AddRange(tickets);
                _context.SaveChanges();
            }
        }
    }
}
