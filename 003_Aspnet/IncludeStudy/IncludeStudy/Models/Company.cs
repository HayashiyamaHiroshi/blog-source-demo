using System.Collections;
using System.Collections.Generic;
using Microsoft.Extensions.Caching.Memory;

namespace IncludeStudy.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }

        public Company(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Company()
        {
            
        }
    }
}