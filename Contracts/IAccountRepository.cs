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
        Response UpdateUser(ApplicationUser updatedUser);
        Task<string> GetUserIdByUserName(string username);
        Task<bool> UserExists(string username);
        Task<bool> UserExistsById(string userId);
        void AddRating(Rating rating);
        double GetAvgRatingForUser(string userId);
    }
}
