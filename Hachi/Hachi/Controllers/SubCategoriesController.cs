using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hachi.Models;
using Hachi.Data;

namespace Hachi.Controllers
{
    public class SubCategoriesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubCategoriesController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var subcategory = from p in _context.SubCategory join d in _context.Category on p.CategoryId equals d.Id select 
            return View();
        }
    }
}