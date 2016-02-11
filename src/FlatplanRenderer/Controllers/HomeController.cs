using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlatplanRenderer.ViewModels;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.OptionsModel;

namespace FlatplanRenderer.Controllers
{
    public class HomeController : Controller
    {
        private readonly IOptions<Data> _data;
        public HomeController(IOptions<Data> data)
        {
            _data = data;
        }
        public IActionResult Index()
        {
            return View(_data.Value.Flatplans);
        }
    }
}
