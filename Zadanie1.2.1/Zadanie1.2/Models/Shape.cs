using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Zadanie1._2.Models
{
    public class Shape
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public DateTime DateBirth { get; set; }
        //public string Company { get; set; }
        public string Number { get; set; }
        [EmailAddress]
        public string Email { get; set; }

        public int OrganizationId { get; set; }
        public Organization Organization { get; set; } 

    }
}
