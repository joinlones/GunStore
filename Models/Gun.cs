// Models/Gun.cs
using System.ComponentModel.DataAnnotations;

namespace GunStore.Models
{
    public class Gun
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Manufacturer { get; set; }

        [Required]
        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}