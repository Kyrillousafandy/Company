using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProjectMapping.Entities
{
    // POCO Class
    internal class Employee
    {
        public int Id { get; set; }
        //[Column(TypeName = "varchar")]
        //[StringLength(50,MinimumLength = 10)]
        public string? Name { get; set; }
        [DataType(DataType.Currency)]
        public double salary { get; set; }
        [Range(18, 50)]
        public int? Age { get; set; }
        [EmailAddress]
        public string EmailAddress { get; set; }
        [Phone]
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        [ForeignKey("Department")]
        public int? DepartmentId { get; set; } // foriegn key
        [InverseProperty("Employees")]
        public Department Department { get; set; } // one navigation
    }
}
