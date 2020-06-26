using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BookStore.Ui.Models
{
    public class Book : Entity
    {
        public string Titulo { get; set; }

        public string SobreNome { get; set; }

        public string Idioma { get; set; }

        public int Isbn { get; set; }

        public short Ano { get; set; }

        public int OrigemId { get; set; }
        [ForeignKey(nameof(OrigemId))]

        public virtual Origem Origem { get; set; }

    }
}