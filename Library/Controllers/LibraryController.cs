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
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Books()
        {
            List<Book> books = new List<Book>();
            books.Add(new Book() { BookId = 1, BookName = "Чистый код", BookType = "Учебная" });
            books.Add(new Book() { BookId = 2, BookName = "Гиперион", BookType = "Развлекательная" });
            ViewBag.Books = books;
            ViewData["Message"] = "Список Книг";

            return View();
        }
        public IActionResult Clients()
        {
            List<Client> clients = new List<Client>();
            clients.Add(new Client() { ClientId = 1, ClientName = "Иванов Иван Иванович" });
            clients.Add(new Client() { ClientId = 2, ClientName = "Петров Петр Петрович" });
            ViewBag.Clients = clients;
            ViewData["Message"] = "Список клиентов библиотеки";

            return View();
        }
    }
}
