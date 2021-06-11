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
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public UsersController(IAccountRepository accountRepository, IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        [HttpGet("{userId}")]
        public async Task<ActionResult<UserDto>> GetUser(string userId)
        {
            var userFromRepo = await _repository.Account.GetUserById(userId);
            var commentsByUserId = _repository.Comment.GetCommentsByUserId(Guid.Parse(userId), trackChanges: false).Count();

            return Ok(_mapper.Map<ApplicationUser, UserDto>(userFromRepo, options => 
                            options.AfterMap((src, dest) => dest.Comments = commentsByUserId)));
        }
        [HttpGet]
        [Route("/testing/test")]
        public ActionResult TestFunc()
        {
            var user = _repository.Account.GetUserById("7012ec90-74f1-4154-a312-5091b56f0dd7").Result;
            user.Rating = 3;
            user.amountOfRatings++;
            var res = _repository.Account.UpdateUser(user);
            _repository.Save();
            return Ok();
        }
        //[HttpPut]
        //public ActionResult RateUser([FromBody] RateUserDto userRating)
        //{
        //    var user = _repository.Account.GetUserById(userRating.UserId).Result;
        //}


    }
}
