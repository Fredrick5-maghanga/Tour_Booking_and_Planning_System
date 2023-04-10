using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace ClassicTours.Models
{
    [Index(nameof(userName), nameof(CPF), nameof(Email), IsUnique = true)]

    public class User
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        [Column("firstName")]
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 2)]
        [Column("lastName")]
        [Display(Name = "First Name")]
        public string lastName { get; set; }


        [Required]
        [StringLength(50, MinimumLength = 2)]
        [Column("userName")]
        [Display(Name = "First Name")]
        public string userName { get; set; }


        [Key]
        public int userId { get; set; }
      
        [Required]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string CPF{ get; set; }
        [Required]
        public string currentAddress { get; set; }
        [Required]
        public string permanentAddress { get; set; }
        [Required]
        public string city { get; set; }
        [Required]  
        public int age { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [Display(Name = "Date of birth")]
        public DateTime DateOfBirt { get; set;}


    }
}
