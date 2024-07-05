using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SimpleBanking.DTOs;
using System.Security.Principal;

namespace SimpleBanking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccount _account;
        public AccountController(IAccount account) 
        {
            _account = account;
        }
        [HttpPost("CreateAccount")]
        public async Task<IActionResult> CreateAccount([FromBody]AccountCreationDTO newAcct)
        {
            try
            {
                var response = _account.CreateAccount(newAcct);
                return Ok(response);

            }
            catch (Exception ex) 
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
