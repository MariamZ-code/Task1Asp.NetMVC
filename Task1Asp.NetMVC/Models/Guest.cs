using System.ComponentModel.DataAnnotations;

namespace Task1Asp.NetMVC.Models
{
    public class Guest
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Email { get; set; }
        
        [MaxLength(50)]
        public string? Phone { get; set; }
        public bool Attend { get; set; }
        [Required]
        [MaxLength(100)]
        public string? Msg { get; set; }



    }
}
