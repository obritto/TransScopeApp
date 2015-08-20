namespace TransScopeApp.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DadosModel : DbContext
    {
        public DadosModel()
            : base("name=DadosModel")
        {
        }

        public virtual DbSet<Pessoa> Pessoa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pessoa>()
                .Property(e => e.poupanca)
                .HasPrecision(19, 4);
        }
    }
}
