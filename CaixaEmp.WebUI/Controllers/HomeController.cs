using CaixaEmp.Application.Interfaces;
using CaixaEmp.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CaixaEmp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IExpenseService _expenseService;

        public HomeController(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        public async Task<IActionResult> Index(int? id)
        {
            var expense = await _expenseService.GetExpenseEmplooyer(id);
            return View(expense);
        }        
    }
}