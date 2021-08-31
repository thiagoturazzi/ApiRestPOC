using System;
using System.ComponentModel.DataAnnotations;

namespace AR.Domain
{
    public class Customer
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Field {0} is required")]
        [MaxLength(50, ErrorMessage = "Field {0} should not exceed the max length {1}")]
        public string Name { get; set; }
        public string CPF { get; set; }
        public int Age { get; set; }
    }
}
