using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookStore.Ui.Models
{
    [Table(nameof(Book))]
    public class Book : Entity
    {
        [Required,Column(TypeName = "varchar"), StringLength(100)]
        public string Titulo { get; set; }

        [Required,Column(TypeName = "varchar"), StringLength(100)]
        public string SobreNome { get; set; }

        [Required,Column(TypeName = "varchar"), StringLength(50)]
        public string Idioma { get; set; }

        [Required]
        public int Isbn { get; set; }
        
        [Required]
        public short Ano { get; set; }

        public int OrigemId { get; set; }
        [ForeignKey(nameof(OrigemId))]

        public virtual Origem Origem { get; set; }

    }
}