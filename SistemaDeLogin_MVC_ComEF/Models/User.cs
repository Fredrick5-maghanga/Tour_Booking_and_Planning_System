using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Policy;

namespace ClassicTours.Models
{
    [Index(nameof(UserName), nameof(Email), IsUnique = true)]

    public class User: IdentityUser
    {
        //public User(string firstName, string lastName, string userName, int userId, string email, string currentAddress, string homeAddress, string City, string Gender, DateTime birthDay ) { }



        //[Required]
        //[StringLength(50, MinimumLength = 2)]
        //[Column("firstName")]
        //[Display(Name = "First Name")]
        //public string firstName { get; set; }

        //[Required]
        //[StringLength(50, MinimumLength = 2)]
        //[Column("lastName")]
        //[Display(Name = "First Name")]
        //public string lastName { get; set; }


        //[Required]
        //[StringLength(50, MinimumLength = 2)]
        //[Column("userName")]
        //[Display(Name = "First Name")]
        //public string userName { get; set; }


        //[Key]
       // public int userId { get; set; }

        [Required]
        public string firstName { get; set; }
        [Required]
        public string lastName { get; set; }
        //[Required]
        //public string userName { get; set; }


        //[Required]
        //public string Email { get; set; }

        [Required]
        public string currentAddress { get; set; }
        [Required]
        public string permanentAddress { get; set; }
        [Required]
        public string city { get; set; }

        [Required]
        public string Gender { get; set; }
        [Required]
        [Display(Name = "Date of birth")]
        public DateTime birthDay{ get; set;}

       
       


    }
   

}
