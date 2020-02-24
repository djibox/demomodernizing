using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FirstTestMigration.Models
{
    public class Agent
    {
        public int Id { get; set; }
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        public string Adress { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public int DivisionId { get; set; }
        public Division Division { get; set; }
    }
}
