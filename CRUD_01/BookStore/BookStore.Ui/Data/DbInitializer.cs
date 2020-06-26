using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using BookStore.Ui.Models;

namespace BookStore.Ui.Data
{
    public class DbInitializer : CreateDatabaseIfNotExists<DataContext>
    {

        //MÉTODO PARA ADICIONAR UM LIVRO NA BASE DE DADOS AO CRIA-LA
        
        //protected override void Seed(DataContext context)
        //{
        //    var brasil = new Origem() { Nome = "BRA" };
        //    var argentina = new Origem() { Nome = "ARG" };

        //    var books = new List<Book>()
        //    {
        //        new Book(){Titulo = "Lion King",Nome = "Joe", SobreNome = "Delaney", Idioma = "English", Isbn = 123456, Ano = 2000, Origem = brasil},
        //        new Book(){Titulo = "The Wild",Nome = "Karen", SobreNome = "Gucci", Idioma = "Spanish", Isbn = 123456, Ano = 2000, Origem = argentina}
        //    };

        //    context.Books.AddRange(books);
        //    context.SaveChanges();

        //}

    }
}