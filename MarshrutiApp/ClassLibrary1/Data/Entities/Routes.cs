using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Entities
{
    public class Routes
    {
        public Routes(int id, string start, string end, string startDate, int days, decimal price)
        {
            this.RouteId = id;
            Start = start;
            End = end;
            StartDate = startDate;
            Days = days;
            Price = price;
        }

        public int RouteId { get; set; }
        [Required]

        public string Start { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(40)]

        public string End { get; set; }
        [Required]
        [MinLength(2)]
        [MaxLength(40)]

        public string StartDate { get; set; }
        [Required]

        public int Days { get; set; }
        [Required]
        

        public decimal Price { get; set; }
        [Required]



    } 
}
