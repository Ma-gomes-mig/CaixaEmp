using CaixaEmp.Application.Interfaces;
using CaixaEmp.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CaixaEmp.WebUI.Controllers
{
    public class ExpenseController : Controller
    {
        private readonly IExpenseService _expenseService;
        public IActionResult Index()
        {
            return View();
        }
    }
}
