namespace EFT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Transaction")]
    public partial class Transaction
    {
        [Key]
        public long Id { get; set; }
        
        public long StudentId { get; set; }
        
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public virtual Student Students { get; set; }

        public virtual ICollection<TranDetail> TranDetails { get; set; }
    }
}
