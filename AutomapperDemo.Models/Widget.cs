using System.ComponentModel.DataAnnotations;

namespace AutomapperDemo.Models
{
    public class Widget
    {
        [Required]
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Cost { get; set; } = decimal.Zero;
    }
}
