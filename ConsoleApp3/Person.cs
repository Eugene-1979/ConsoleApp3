using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Entity
    {
    public class Person
        {
        public void F() { }

        public int Id { get; set; }
     
        public int Age { get; set; }
       [Required]
        public string Name { get; set; }
        }
    }
