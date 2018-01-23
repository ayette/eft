namespace EFT
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TranDetail")]
    public partial class TranDetail
    {
        public long Id { get; set; }

        public long TransactionId { get; set; }

        [StringLength(50)]
        public string Code { get; set; }

        [Required]
        [StringLength(50)]
        public string Description { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }
        
    }
}
