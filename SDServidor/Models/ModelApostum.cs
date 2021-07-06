using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace SDServidor.Models
{
    public partial class ModelApostum
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("chave")]
        [StringLength(300)]
        public string Chave { get; set; }
        [Required]
        [Column("data")]
        [StringLength(300)]
        public string Data { get; set; }
        [Column("registada")]
        public bool? Registada { get; set; }
        [Column("utilizadorId")]
        public int? UtilizadorId { get; set; }

        [ForeignKey(nameof(UtilizadorId))]
        [InverseProperty(nameof(ModelUtilizador.ModelAposta))]
        public virtual ModelUtilizador Utilizador { get; set; }
    }
}
