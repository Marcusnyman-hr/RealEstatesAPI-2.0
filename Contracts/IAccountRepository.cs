using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IAccountRepository
    {
        Task<Response> RegisterAccount(RegisterModel newUser);
        Task<Token> GetJwtToken(LoginModel loginInfo);
        //Task<IQueryable<ApplicationUser>> GetUsersAsync();
        Task<ApplicationUser> GetUserById(string userId);
    }
}
