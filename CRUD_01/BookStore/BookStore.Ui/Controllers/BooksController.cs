using BookStore.Ui.Data;
using BookStore.Ui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookStore.Ui.Controllers
{
    public class BooksController : Controller
    {
        public ViewResult Index()
        {
            IList<Book> books = null;
            using (var context = new DataContext())
            {
                books = context.Books.ToList();
            }

            return View(books);
        }
    }
}