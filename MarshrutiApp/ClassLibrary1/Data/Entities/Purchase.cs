using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Entities
{
    public class Purchase
    {
        public int Id { get; set; }
        [ForeignKey("Routes")]
        [Required]

        public int RouteId { get; set; }

        public Routes Routes { get; set; } = null!;
        [ForeignKey("Clients")]
        [Required]

        public int ClientId { get; set; }

        public Clients Clients { get; set; } = null!;
        [Required]
        
        public DateTime PurchaseDate { get; set; }7

        public int RequestCount { get; set; }
        [Required]
        [MaxLength(10)]
    }
}
