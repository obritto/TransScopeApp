namespace TransScopeApp.MyModels
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyDadosModel : DbContext
    {
        public MyDadosModel()
            : base("name=MyDadosModel")
        {
        }

        public virtual DbSet<pessoa> pessoa { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<pessoa>()
                .Property(e => e.nome)
                .IsUnicode(false);

            modelBuilder.Entity<pessoa>()
                .Property(e => e.telefone)
                .IsUnicode(false);
        }
    }
}
