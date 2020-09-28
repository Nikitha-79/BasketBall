using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BasketBall.Controllers
{
    public class FootBallController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
