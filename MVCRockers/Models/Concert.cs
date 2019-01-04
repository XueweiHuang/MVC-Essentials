using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCRockers.Models
{
    public class Concert
    {

        public string Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string City { get; set; }
        [Display(Name="concert date")]

        public DateTime ConcertDate { get; set; }
        [Display(Name ="backstage passes")]
        public int Tickets { get; set; }
        [DataType(DataType.Currency)]
        public double price { get; set; }
        [Display(Name="Passcode")]
        [RegularExpression(@"\d(3,9)", ErrorMessage ="passcode must be 3-9 digits")]
        public string Password { get; set; }
        public string PromoterName { get; set; }
    }
}