using Contracts;
using Entities;
using Entities.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IConfiguration _configuration;
        private readonly AuthenticationContext _authenticationContext;
        public AccountRepository(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration, AuthenticationContext authenticationContext)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            _configuration = configuration;
            _authenticationContext = authenticationContext;
        }

        public async Task<Response> RegisterAccount(RegisterModel newUser)
        {
            if (newUser == null)
            {
                throw new ArgumentNullException(nameof(newUser));
            }
            var userExists = await userManager.FindByNameAsync(newUser.Username);
            if (userExists != null)
                return new Response { Status = "Error", Message = "User already exists!" };

            ApplicationUser user = new ApplicationUser()
            {
                Email = newUser.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = newUser.Username
            };
            var result = await userManager.CreateAsync(user, newUser.Password);
            if (!result.Succeeded)
                return new Response { Status = "Error", Message = result.Errors.First().Description };

            return new Response { Status = "Success", Message = "User created successfully!" };
        }
        public async Task<Token> GetJwtToken(LoginModel loginInfo)
        {
            var user = await userManager.FindByNameAsync(loginInfo.Username);
            if (user != null && await userManager.CheckPasswordAsync(user, loginInfo.Password))
            {
                var userRoles = await userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.UserName),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

                var token = new JwtSecurityToken(
                    issuer: _configuration["JWT:ValidIssuer"],
                    audience: _configuration["JWT:ValidAudience"],
                    expires: DateTime.Now.AddDays(14),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );
                return new Token()
                {
                    access_token = new JwtSecurityTokenHandler().WriteToken(token),
                    token_type = "bearer",
                    expires_in = (int)(token.ValidTo - DateTime.Now).TotalSeconds,
                    userName = user.UserName,
                    issued = DateTime.Now.ToString("ddd, dd MMM yyy HH':'mm':'ss 'GMT'"),
                    expires = token.ValidTo.ToString("ddd, dd MMM yyy HH':'mm':'ss 'GMT'")
                };
            }
            return new Token() { };
        }

        public Task<ApplicationUser> GetUserById(string userId)
        {
            var userRatings = _authenticationContext.Ratings.Where(r => r.UserId.Equals(userId)).ToList();
            var user =  userManager.FindByIdAsync(userId);
            //if(userRatings != null)
            //{
            //    user.Result.Ratings = userRatings;
            //}
            return user;
        }

        public Response UpdateUser(ApplicationUser updatedUser)
        {
            var success = userManager.UpdateAsync(updatedUser);
            return new Response() { Status = "Success", Message = "Updated user" };
        }

        public async Task<string> GetUserIdByUserName(string username)
        {
            ApplicationUser user = await userManager.FindByNameAsync(username);
            return user.Id;
        }

    }
}
