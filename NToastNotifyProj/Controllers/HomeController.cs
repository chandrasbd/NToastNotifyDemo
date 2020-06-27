using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using NToastNotify;

using NToastNotifyProj.Models;

namespace NToastNotifyProj.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IToastNotification toastNotification;

        public HomeController (ILogger<HomeController> logger, IToastNotification toastNotification)
        {
            _logger = logger;
            this.toastNotification = toastNotification;
        }

        public IActionResult Index ()
        {
            toastNotification.AddSuccessToastMessage("Notification from NToastNotify"); // it will be load when home page rendered
            return View();
        }

        public IActionResult Privacy ()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error ()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
