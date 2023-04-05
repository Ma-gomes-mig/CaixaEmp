using CaixaEmp.Infra.Data.Context;
using CaixaEmp.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace CaixaEmp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private  ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        

        public async Task<IActionResult> Index()
        {
            return View(await _context.Expenses.ToListAsync());
        }

        
    }
}