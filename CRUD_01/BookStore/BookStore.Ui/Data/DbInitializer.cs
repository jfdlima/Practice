using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookStore.Ui.Data
{
    public class DbInitializer : CreateDatabaseIfNotExists<DataContext>
    {

        //MÉTODO PARA ADICIONAR UM LIVRO NA BASE DE DADOS AO CRIA-LA
        //
        //protected override void Seed(DataContext context)
        //{
        //    var modelbooks = new List<Book>()
        //    {
        //        new Book(){Id = 1, Titulo = "Lion King", Nome = "Fredd", SobreNome = "Mercury",  Idioma = "English", Origem = "FRA", Isbn = 12349322, Ano = 2000 },
        //        new Book(){Id = 2, Titulo = "The Great Gatsby", Nome = "Joe", SobreNome = "Delaney",  Idioma = "English", Origem = "USA", Isbn = 12349322, Ano = 1990 },
        //        new Book(){Id = 3, Titulo = "Geração de valor", Nome = "Flavio", SobreNome = "Augusto",  Idioma = "Portuguese", Origem = "BRA", Isbn = 12349322, Ano = 2018 },
        //        new Book(){Id = 4, Titulo = "The Bitcoin", Nome = "Lindsay", SobreNome = "Lohan",  Idioma = "English", Origem = "AUS", Isbn = 12349322, Ano = 2006 }
        //    };

        //    context.Books.AddRange(modelbooks);
        //    context.SaveChanges();
        //}

    }
}