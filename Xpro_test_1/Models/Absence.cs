using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Xpro_test_1.Models
{
    public class Absence
    {
        public int Id { get; set; }

        [Required]
        public string Type { get; set; } 

        //public ICollection<WorkLog> WorkLogs { get; set; }
    }
}
