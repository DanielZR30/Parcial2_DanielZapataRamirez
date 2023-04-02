using System.ComponentModel.DataAnnotations;

namespace TicketSystem.DAL.Entities
{
    public class Entity
    {
        [Key]
        [Required]
        public  Guid Id { get; set; }

    }
}
