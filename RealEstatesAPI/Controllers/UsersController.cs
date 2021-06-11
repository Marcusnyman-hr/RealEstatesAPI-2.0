using AutoMapper;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstatesAPI.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstatesAPI.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IAccountRepository _accountRepository;
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public UsersController(IAccountRepository accountRepository, IRepositoryManager repository, IMapper mapper)
        {
            _accountRepository = accountRepository;
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet("{userId}")]
        public async Task<ActionResult<UserDto>> GetUser(string userId)
        {
            var userFromRepo = await _accountRepository.GetUserById(userId);
            var commentsByUserId = _repository.Comment.GetCommentsByUserId(Guid.Parse(userId), trackChanges: false).Count();

            return Ok(_mapper.Map<ApplicationUser, UserDto>(userFromRepo, options => 
                            options.AfterMap((src, dest) => dest.Comments = commentsByUserId)));
        }

    }
}
