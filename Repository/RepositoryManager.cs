using Contracts;
using Entities;
using Entities.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private AuthenticationContext _authenticationContext;
        private IRealEstateRepository _realEstateRepository;
        private ICommentRepository _commentRepository;
        private AccountRepository _accountRepository;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly IHostingEnvironment _environment;

        public RepositoryManager(RepositoryContext repositoryContext, AuthenticationContext authenticationContext, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration, IHostingEnvironment environment)
        {
            _repositoryContext = repositoryContext;
            _authenticationContext = authenticationContext;
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            _environment = environment;
        }

        public IRealEstateRepository RealEstate
        {
            get
            {
                if (_realEstateRepository == null)
                    _realEstateRepository = new RealEstateRepository(_repositoryContext, _environment);
                return _realEstateRepository;
            }
        }

        public ICommentRepository Comment
        {
            get
            {
                if (_commentRepository == null)
                    _commentRepository = new CommentRepository(_repositoryContext);
                return _commentRepository;
            }
        }

        public IAccountRepository Account
        {
            get
            {
                if (_accountRepository == null)
                    _accountRepository = new AccountRepository(_userManager, _roleManager, _configuration, _authenticationContext);
                return _accountRepository;
            }
        }

        public void Save()
        {
            if (_repositoryContext.ChangeTracker.HasChanges())
            {
                _repositoryContext.SaveChanges();
            }
            if(_authenticationContext.ChangeTracker.HasChanges())
            {
                _authenticationContext.SaveChanges();
            }
        }
    }
}
