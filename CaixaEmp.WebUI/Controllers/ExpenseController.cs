using CaixaEmp.Application.DTOs;
using CaixaEmp.Application.Interfaces;
using CaixaEmp.Domain.Interfaces;
using CaixaEmp.Infra.Data.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CaixaEmp.WebUI.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly ApplicationDbContext _applicationDbContext;
        private readonly IExpenseService _expenseService;
        public ExpenseController(IExpenseService expenseService, ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            _expenseService = expenseService;
        } 

        public async Task<IActionResult> Index()
        {
            var expense = await _expenseService.GetAllExpenseAsync();
            return View(expense);
        }

        [HttpGet]
        public IActionResult Create() 
        {
            ViewData["CategoryId"] = new SelectList(_applicationDbContext.Categories, "CategoryId", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ExpenseDTO expense)
        {
            if(ModelState.IsValid)
            {
                TempData["Confirmacao"] = expense.Name + "foi cadastrada com sucesso.";
                await _expenseService.Create(expense);
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_applicationDbContext.Categories, "CategoryId", "Name");
            return View(expense);
        }
    }
}
