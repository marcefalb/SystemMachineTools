namespace System_Machine_Tools
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Autorizetion> Autorizetions { get; set; }
        public virtual DbSet<Brigade> Brigades { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Machine> Machines { get; set; }
        public virtual DbSet<Made> Mades { get; set; }
        public virtual DbSet<Vid_machine> Vid_machine { get; set; }
        public virtual DbSet<Vid_Remont> Vid_Remont { get; set; }
        public virtual DbSet<Zakaz> Zakazs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autorizetion>()
                .Property(e => e.Status_auto)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Brigade>()
                .HasMany(e => e.Zakazs)
                .WithRequired(e => e.Brigade)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Telefon)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.File_foto_client)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Machines)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Machine>()
                .HasMany(e => e.Zakazs)
                .WithRequired(e => e.Machine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Made>()
                .HasMany(e => e.Machines)
                .WithRequired(e => e.Made)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vid_machine>()
                .HasMany(e => e.Machines)
                .WithRequired(e => e.Vid_machine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Vid_Remont>()
                .Property(e => e.Machine_name)
                .HasPrecision(10, 2);

            modelBuilder.Entity<Vid_Remont>()
                .HasMany(e => e.Zakazs)
                .WithRequired(e => e.Vid_Remont1)
                .HasForeignKey(e => e.Vid_remont)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Zakaz>()
                .Property(e => e.Status_zakaza)
                .IsFixedLength()
                .IsUnicode(false);
        }
    }
}
