using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vesperr.Models;

namespace Vesperr.ViewModels
{
    public class HomeViewModel
    {
        public List<Service> Services { get; set; }
        public List<Testimonial> Testimonials { get; set; }
    }
}
