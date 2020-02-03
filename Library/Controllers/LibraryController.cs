using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Library.Models;

namespace Library.Controllers
{
    public class LibraryController : Controller
    {
        private LibraryContext context;

        public LibraryController(LibraryContext ctx) => context = ctx;

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Books()
        {
            return View(context.Books);
        }

        public IActionResult AddBook() => View();

        [HttpPost]
        public IActionResult AddBook(Book book)
        {
            context.Books.Add(book);
            context.SaveChanges();
            return RedirectToAction(nameof(Books));
        }
        
        public IActionResult Clients()
        {
            return View(context.Clients);
        }

        public IActionResult AddClient() => View();

        [HttpPost]
        public IActionResult AddClient(Client client)
        {
            context.Clients.Add(client);
            context.SaveChanges();
            return RedirectToAction(nameof(Clients));
        }
    }
}
