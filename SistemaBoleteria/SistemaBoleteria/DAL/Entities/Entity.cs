using System.ComponentModel.DataAnnotations;

namespace SistemaBoleteria.DAL.Entities
{
    public class Entity
    {
        [Key]
        [Required]
        public  int Id { get; set; }

    }
}
