using MVC_Sample.Models;
using MVC_Sample.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.MappingViews;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Sample.Controllers
{
    public class BookController : Controller
    {
        List<Book> books = null;
        List<Customer> customers = null;
        CustomerBookViewModel cbVm = null;
        public BookController()
        {
            this.books = new List<Book>();
            Book b1 = new Book { Id = 1, Name = "A" };
            Book b2 = new Book { Id = 2, Name = "B" };
            Book b3 = new Book { Id = 3, Name = "C" };
            Book b4 = new Book { Id = 4, Name = "D" };

            books.Add(b1);
            books.Add(b2);
            books.Add(b3);
            books.Add(b4);

            customers = new List<Customer>();
            Customer c1 = new Customer { Id = 1, Name = "AAA" };
            Customer c2 = new Customer { Id = 2, Name = "BBB" };
            Customer c3 = new Customer { Id = 3, Name = "CCC" };
            Customer c4 = new Customer { Id = 4, Name = "DDD" };

            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);
            customers.Add(c4);
            cbVm = new CustomerBookViewModel() { Books = books, Customers = customers };


        }
        // GET: Book
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetBooks()
        {

            return View(books);
        }

        public ActionResult GetBookById(int id)
        {
            if (this.books != null)
            {
                var bookItem = this.books.Where(x => x.Id == id).FirstOrDefault();
                return View(bookItem);
            }
            return new EmptyResult();
        }

        public ActionResult GetBookByName(int id, string name)
        {
            if (this.books != null)
            {
                var bookItem = this.books.Where(x => x.Id == id).FirstOrDefault();
                bookItem.Name = name;
                return Content($"Id {bookItem.Id} -- Name {bookItem.Name}");
                // return View(bookItem);
            }
            return new EmptyResult();
        }

        [Route("Book/Kiran/{id}/{name}")]
        public ActionResult GetBookName(int id, string name)
        {
            if (this.books != null)
            {
                //var bookItem = this.books.Where(x => x.Id == id).FirstOrDefault();
                //bookItem.Name = name;
                //return Content($"Id {bookItem.Id} -- Name {bookItem.Name}");
                return View(cbVm);
            }
            return new EmptyResult();
        }

        public ActionResult NewBook()
        {
            return View();
        }
    }
}