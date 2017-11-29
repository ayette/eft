namespace EFT
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Database : DbContext
    {
        public Database()
            : base("name=EFTDatabase")
        {
        }

        public virtual DbSet<Menu> Menus { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Transaction> Transactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(e => e.LastName)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.FirstName)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .HasMany(e => e.Transactions)
                .WithRequired(e => e.Student)
                .WillCascadeOnDelete(false);
        }
    }
}
