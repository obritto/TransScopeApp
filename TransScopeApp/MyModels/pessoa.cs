namespace TransScopeApp.MyModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("estudo.pessoa")]
    public partial class pessoa
    {
        [Key]
        public int idPessoa { get; set; }

        [StringLength(45)]
        public string nome { get; set; }

        [StringLength(10)]
        public string telefone { get; set; }
    }
}
