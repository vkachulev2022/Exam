using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data.Entities
{
    public class Clients
    {
        public Clients(int id, string name, string surname, int eGN, int idnumber, string email)
        {
            this.ClientId = ClientId;
            this.Name = name;
            this.Surname = surname;
            this.EGN = eGN;
            this.Idnumber = idnumber;
            this.Email = email;
        }

        public int ClientId { get; set; } 
        [Required]

        public string Name { get; set; } = null!;
        [Required]
        [MinLength(2)]
        [MaxLength(10)]

        public string Surname { get; set; } = null!;       
        [Required]
        [MinLength(2)]
        [MaxLength(10)]

        public int EGN { get; set; } 
        [Required]

        public int Idnumber { get; set; } 
        [Required]

        public string Email { get; set; } = null!;
        [Required]

    }
}
