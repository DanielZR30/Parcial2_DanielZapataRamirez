using System.ComponentModel.DataAnnotations;

namespace TicketSystem.DAL.Entities
{
    public class Ticket : Entity
    {
        [Display(Name = "¿Tiquete utilizado?")]
        public DateTime? UseDate { get; set; }

        [Display(Name = "Puerta de Ingreso")]
        public bool IsUsed { get; set; } = false;

        [Display(Name = "Puerta de Ingreso")]
        public string? EntranceGate { get; set; }

    }
}
