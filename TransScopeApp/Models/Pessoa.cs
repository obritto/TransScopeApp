namespace TransScopeApp.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pessoa")]
    public partial class Pessoa
    {
        [Key]
        public int idPessoa { get; set; }

        [StringLength(50)]
        public string nome { get; set; }

        [StringLength(50)]
        public string telefone { get; set; }

        [Column(TypeName = "money")]
        public decimal poupanca { get; set; }
    }
}
