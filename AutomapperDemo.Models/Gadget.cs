using System.ComponentModel.DataAnnotations;

namespace AutomapperDemo.Models
{
    public class Gadget
    {
        [Required]
        [Display(Name = "Key")]
        public string Key { get; set; } = string.Empty;

        [Required]
        [Display(Name = "Type of Gadget")]
        public string GadgetType { get; set; } = string.Empty;

        [Display(Name = "Usage Instructions")]
        public string UsageInstructions { get; set; } = string.Empty;
    }
}
