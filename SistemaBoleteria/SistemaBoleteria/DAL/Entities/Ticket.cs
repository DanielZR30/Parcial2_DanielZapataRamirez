namespace SistemaBoleteria.DAL.Entities
{
    public class Ticket
    {
        public DateTime? _UseDate { get; set; }

        public bool _IsUsed { get; set; } = false;

        public string? _EntranceGate { get; set; }

    }
}
