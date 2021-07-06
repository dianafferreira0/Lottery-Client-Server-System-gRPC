using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SDServidor.Models
{
    [Table("ModelUtilizador")]
    public partial class ModelUtilizador
    {
        public ModelUtilizador()
        {
            ModelAposta = new HashSet<ModelApostum>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [Column("nome")]
        [StringLength(300)]
        public string Nome { get; set; }

        [InverseProperty(nameof(ModelApostum.Utilizador))]
        public virtual ICollection<ModelApostum> ModelAposta { get; set; }
    }
}
