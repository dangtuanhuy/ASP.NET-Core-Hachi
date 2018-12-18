using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Hachi.Models;
using Hachi.Data;
using Microsoft.EntityFrameworkCore;
using Hachi.Models.SubCategoryViewModels;
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
            var subcategory = _context.SubCategory.Include(p=>p.Category);
            return View(await subcategory.ToListAsync());
        }
        //GET Action for Create
        public IActionResult Create()
        {
            SubCategoryAndCategoryViewModel model = new SubCategoryAndCategoryViewModel()
            {
                CategoryList = _context.Category.ToList(),
                SubCategory = new SubCategory(),
                SubCategoryList = _context.SubCategory.OrderBy(p => p.SubCategoryName).Select(p => p.SubCategoryName).ToList()
            };
            return View(model);
        }
    }
}