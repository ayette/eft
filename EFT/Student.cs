namespace EFT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Student")]
    public partial class Student
    {
        
        public Student()
        {
            
        }

        public long Id { get; set; }

        [StringLength(50)]
        public string Number { get; set; }

        [StringLength(10)]
        public string LastName { get; set; }

        [StringLength(10)]
        public string FirstName { get; set; }

        public decimal Amount { get; set; }
        
    }
}
