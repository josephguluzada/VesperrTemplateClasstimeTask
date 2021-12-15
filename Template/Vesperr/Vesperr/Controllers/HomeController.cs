using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vesperr.Models;
using Vesperr.ViewModels;

namespace Vesperr.Controllers
{
    public class HomeController : Controller
    {
        private List<Service> _services;
        private List<Testimonial> _testimonials;
        public HomeController()
        {
            _services = new List<Service>
            {
                new Service
                {
                    Id = 1,Title = "Title1",SubTitle="Subtitle1",Icon = "Icon1"
                },
                new Service
                {
                    Id = 2,Title = "Title2",SubTitle="Subtitle1",Icon = "Icon1"
                },
                new Service
                {
                    Id = 3,Title = "Title3",SubTitle="Subtitle1",Icon = "Icon1"
                },
                new Service
                {
                    Id = 4,Title = "Title4",SubTitle="Subtitle1",Icon = "Icon1"
                }

            };

            _testimonials = new List<Testimonial>
            {
                new Testimonial
                {
                    Id = 1,FullName= "Yusif Guluzada",Position="Teacher",Description="Desc"
                },
                new Testimonial
                {
                    Id = 1,FullName= "Vasif Guluzada",Position="Student",Description="Desc"
                },
                new Testimonial
                {
                    Id = 1,FullName= "Agasif Guluzada",Position="Kid",Description="Desc"
                },
            };
        }


        public IActionResult Index()
        {
            HomeViewModel homeVM = new HomeViewModel
            {
                Services = _services,
                Testimonials = _testimonials
            };

            return View(homeVM);
        }
    }
}
