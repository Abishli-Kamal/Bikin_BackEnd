using System.ComponentModel.DataAnnotations;

namespace Bikin_Back_End.Models
{
    public class ServicesM
    {
        public int Id { get; set; }
        [Required]
        public string Icon { get; set; }
        [Required]
        public string Title { get; set; }
         [Required]
        public string Description { get; set; }
    }
}
