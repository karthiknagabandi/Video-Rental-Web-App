using MVC_Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_Application.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie{ get; set; }
        public List<Customer> Customers { get; set; }
    }
}
