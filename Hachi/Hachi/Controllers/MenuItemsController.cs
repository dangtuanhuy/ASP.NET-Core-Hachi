using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hachi.Data;
using Hachi.Models.MenuItemViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hachi.Controllers
{
    public class MenuItemsController : Controller
    {
        private readonly ApplicationDbContext _db;
        private readonly IHostingEnvironment _hostingEnvironment;
        [BindProperty]
        public MenuItemViewModel MenuItemVM { get; set; }
        public MenuItemsController(ApplicationDbContext db, IHostingEnvironment hostingEnvironment)
        {
            _db = db;
            _hostingEnvironment = hostingEnvironment;
            MenuItemVM = new MenuItemViewModel()
            {
                Category = _db.Category.ToList(),
                MenuItem = new Models.MenuItem()
            };
        }



        public async Task<IActionResult> Index()
        {
            var memuItem = _db.MenuItem.Include(m => m.Category).Include(m => m.SubCategory);
            return View(await memuItem.ToListAsync());
        }
        //Get MenuItem Create
        public IActionResult Create()
        {
            return View(MenuItemVM);
        }
    }
}