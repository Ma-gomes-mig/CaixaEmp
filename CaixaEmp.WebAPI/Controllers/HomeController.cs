using CaixaEmp.Application.DTOs;
using CaixaEmp.Application.Interfaces;
using CaixaEmp.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CaixaEmp.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private IExpenseService _expenseService;

        public HomeController(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        [HttpGet("ExpenseEmplooyer")]
        public ActionResult<IAsyncEnumerable<Expense>> GetExpenseEmplooyer()
        {
            try
            {
                var expense =  _expenseService.GetExpenseEmplooyer;
                return Ok(expense);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro ao obter as despesas");
            }
        }
        
    }
}
