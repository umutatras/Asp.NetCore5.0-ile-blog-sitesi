﻿using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();

            list.Add(new CategoryClass { categoryName = "Teknoloji", categoryCount = 10 });
            list.Add(new CategoryClass { categoryName = "Yazılım", categoryCount = 14 });
            list.Add(new CategoryClass { categoryName = "Spor", categoryCount = 5});
            list.Add(new CategoryClass { categoryName = "Film", categoryCount = 25});
            return Json(new { jsonlist = list })
;

        }
    }
}
