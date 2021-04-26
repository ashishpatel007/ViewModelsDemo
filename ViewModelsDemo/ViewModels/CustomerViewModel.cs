using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewModelsDemo.Models;

namespace ViewModelsDemo.ViewModels
{
    public class CustomerViewModel
    {
        public List<Book> Books { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
