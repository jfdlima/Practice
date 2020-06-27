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
        [Required(ErrorMessage = "{0} is required"),Column(TypeName = "varchar"), StringLength(100)]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Please enter a last name") ,Column(TypeName = "varchar"), StringLength(100)]
        public string SobreNome { get; set; }

        [Required(ErrorMessage = "Language is required" ),Column(TypeName = "varchar"), StringLength(50)]
        public string Idioma { get; set; }

        [Required(ErrorMessage = "ISBN is required")]
        public int Isbn { get; set; }
        
        [Required(ErrorMessage = "{0} is required")]
        public short Ano { get; set; }

        [Required(ErrorMessage = "INFORME O PAIS MEU BOM")]
        public int OrigemId { get; set; }
        [ForeignKey(nameof(OrigemId))]

        public virtual Origem Origem { get; set; }

    }
}