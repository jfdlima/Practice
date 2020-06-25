using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Ui.Models
{
    public class Book
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Nome { get; set; }

        public string SobreNome { get; set; }

        public string Idioma { get; set; }

        public string Origem { get; set; }

        public int Isbn { get; set; }

        public short Ano { get; set; }
    }
}