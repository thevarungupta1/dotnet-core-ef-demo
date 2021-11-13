using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebUI.Data
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required]
        public string Name { get; set; }

        [Column(TypeName = "varchar(250)")]
        public string Address { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Contact { get; set; }
    }
}
