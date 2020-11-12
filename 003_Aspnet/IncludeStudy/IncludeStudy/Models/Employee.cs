using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IncludeStudy.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [ForeignKey("Company")]
        public virtual int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public Employee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Employee()
        {
            
        }
    }
}