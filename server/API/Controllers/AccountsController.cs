using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountsController : Controller
    {
        private readonly IAccountsServices _accountsServices;
        public AccountsController(IAccountsServices accountsService) =>
        _accountsServices = accountsService;

        [HttpGet]
        public async Task<IActionResult> GetAccounts() {

        var accounts =  await _accountsServices.GetAccounts();

         // response
         return Ok(accounts);
        }

    }
}
