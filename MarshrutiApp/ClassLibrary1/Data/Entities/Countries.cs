using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Entities
{
    public class Countries
    {
        public Countries(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public int id { get; set; }
        [Required]

        public string name { get; set; }
        [Required]
        [MaxLength(30)]
    }
}
