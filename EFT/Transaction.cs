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
        public long Id { get; set; }

        public long StudentId { get; set; }

        public bool IsDebit { get; set; }

        public decimal Amount { get; set; }

        public virtual Student Student { get; set; }
    }
}
