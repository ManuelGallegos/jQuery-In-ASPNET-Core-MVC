using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace Jquery_In_ASPNET_Core_MVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult List()
        {
            return View();
        }
    }
}
