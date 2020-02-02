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
            if (context.Books.Any())
            {
                return View(context.Books);
            }
            else
            {
                var books = new List<Book>()
                {
                    new Book() { BookId = 1, BookName = "CLR via C#", BookType = "Учебная" },
                    new Book() { BookId = 2, BookName = "Воин", BookType = "Развлекательная" },
                };

                context.Books.AddRange(books);
                context.SaveChanges();

                ViewData["Message"] = "Список Книг";

                return View(context.Books);
            }
        }
        public IActionResult Clients()
        {
            if (context.Clients.Any())
            {
                return View(context.Clients);
            }
            else
            {
                var clients = new List<Client>()
                {
                    new Client() { ClientId = 1, ClientName = "Иванов Максим Иванович" },
                    new Client() { ClientId = 2, ClientName = "Петров Евгений Петрович" },
                };

                context.Clients.AddRange(clients);
                context.SaveChanges();

                ViewData["Message"] = "Список клиентов библиотеки";

                return View(context.Clients);
            }
        }
    }
}
