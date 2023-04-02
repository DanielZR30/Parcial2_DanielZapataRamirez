using System.ComponentModel.DataAnnotations;

namespace TicketSystem.DAL.Entities
{
    public class Ticket : Entity
    {
        [Display(Name = "Fecha de utilizacion")]
        public DateTime? UseDate { get; set; }

        [Display(Name = "¿Tiquete utilizado?")]
        public bool IsUsed { get; set; } = false;

        [Display(Name = "Puerta de Ingreso")]
        public string? EntranceGate { get; set; }

    }
}
