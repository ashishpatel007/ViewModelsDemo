using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ViewModelsDemo.Models;
using ViewModelsDemo.ViewModels;

/**
 * https://www.c-sharpcorner.com/article/managing-data-with-viewmodel-in-asp-net-mvc/
 */
namespace ViewModelsDemo.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            var Book = new List<Book>()
            {
                new Book {BookName = "Programming in C#"},
                new Book {BookName = "Programming in C++"},
                new Book {BookName = "Programming in Java"}
            };

            var Customer = new List<Customer>()
            {
                new Customer {CustomerName = "Zain"},
                new Customer {CustomerName = "Hassan"}
            };

            var CustomerViewModel = new CustomerViewModel
            {
                Books = Book,
                Customers = Customer
            };

            return View(CustomerViewModel);     // pass the ViewModel to the View
        }

    }
}
