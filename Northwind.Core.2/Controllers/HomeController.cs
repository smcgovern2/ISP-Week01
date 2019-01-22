using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Northwind.Core._2.Controllers
{
    public class HomeController : Controller
    {
        public String Index()
        {
            return "This is Lambda";
        }
    }
}