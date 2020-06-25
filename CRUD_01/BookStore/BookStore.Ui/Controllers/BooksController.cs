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
        private readonly DataContext context = new DataContext();

        public ViewResult Index()
        {
            var books = context.Books.ToList();

            return View(books);
        }

        [HttpGet]
        public ActionResult Add(int ? id)
        {
            Book book = new Book();

            if (id != null)
            {
                book = context.Books.Find(id);
            }

            return View(book);
        }
        
        [HttpPost]
        public ActionResult Add(Book bookNew)
        {
            if(bookNew.Id == 0)
            {
                context.Books.Add(bookNew);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

            return Edit(bookNew);
        }

        protected ActionResult Edit(Book bookOld)
        {
            context.Entry(bookOld).State = System.Data.Entity.EntityState.Modified;
           
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Del(int id)
        {
            var book = context.Books.Find(id);
            if(book == null)
            {
                return HttpNotFound();
            }

            context.Books.Remove(book);
            context.SaveChanges();

            return null;
            
        }


        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }

    }
}