using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ClassicTours.Models
{
    

    public class Reservation
    {
       
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        
        public DateTime ArrivalDateTime { get; set; }

        public DateTime DepatureDateTime { get; set; }
        public int NumberOfPeoplet { get; set; }
        [NotMapped]
        public string ArrivalDate => ArrivalDateTime.ToString("MM/dd/yy");
        [NotMapped]
        public string ArrivalTime => ArrivalDateTime.ToString("hh/mm/tt");
        [NotMapped]
        public string DepatureDate => DepatureDateTime.ToString("hh/mm/tt");
        [NotMapped]
        public string DepatureTime => DepatureDateTime.ToString("hh/mm/tt");


    }
}