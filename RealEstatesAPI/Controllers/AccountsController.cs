using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Contracts;

namespace RealEstatesAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;

        public AccountsController(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }
        //register
        [HttpPost]
        [Route("account/register")]
        public async Task<IActionResult> Register([FromForm] RegisterModel newUser)
        {
            var result = _accountRepository.RegisterAccount(newUser).Result;
            if(result.Status == "Error")
            {
                return StatusCode(StatusCodes.Status500InternalServerError, result);
            }
            return Ok(new Response { Status = "Success", Message = "User created successfully!" });
        }
        //[HttpGet]
        //public IActionResult GetUsers()
        //{
        //    _accountRepository.GetUsersAsync();
        //    return Ok();
        //}


        [HttpPost]
        [Route("token")]
        public async Task<IActionResult> Login([FromForm] LoginModel loginInfo)
        {
            var newToken = await _accountRepository.GetJwtToken(loginInfo);
            if(newToken.access_token == null)
            {
                return Unauthorized();
            }

            return Ok(newToken);
            }
        }
    }
