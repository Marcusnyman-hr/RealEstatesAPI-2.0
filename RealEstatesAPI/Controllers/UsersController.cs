using AutoMapper;
using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstatesAPI.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstatesAPI.Controllers
{
    [Authorize]
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
        [AllowAnonymous]
        [HttpGet("{username}")]
        public async Task<ActionResult<UserDto>> GetUser(string username)
        {
            var userExists = await _repository.Account.UserExists(username);
            if (!userExists)
            {
                return NotFound();
            }
            var userId = await _repository.Account.GetUserIdByUserName(username);
            var commentsByUserId = _repository.Comment.GetCommentsByUserId(Guid.Parse(userId), trackChanges: false).Count();
            var avgRating = _repository.Account.GetAvgRatingForUser(userId);
            var amountOfRealEstates = _repository.RealEstate.GetAmountOfRealEstatesByUser(userId);


            return Ok(new
            {
                username = username,
                RealEstates = amountOfRealEstates,
                Comments = commentsByUserId,
                Rating = avgRating
            }) ;
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
        [HttpPost("rate")]
        public async Task<ActionResult> RateUser(RateUserDto userRating)
        {
            var userExists = await _repository.Account.UserExistsById(userRating.UserId);
            if (!userExists)
            {
                return NotFound();
            }
            var userWhosRatingId = await _repository.Account.GetUserIdByUserName(User.Identity.Name);
            if (userWhosRatingId == userRating.UserId)
            {
                return Forbid();
            }
            _repository.Account.AddRating(_mapper.Map<Rating>(userRating));
            _repository.Save();
            return Ok();
        }


        [HttpPost("rateByUserName")]
        public async Task<ActionResult> RateByUserName(RateUserByUserNameDto userRatingDto)
        {
            if (userRatingDto.Value < 1 && userRatingDto.Value > 5)
            {
                return Forbid("Rating can be between 1-5");
            }
            var userId = await _repository.Account.GetUserIdByUserName(userRatingDto.UserName);
            var userExists = await _repository.Account.UserExistsById(userId);
            if (!userExists)
            {
                return NotFound();
            }
            var userWhosRatingId = await _repository.Account.GetUserIdByUserName(User.Identity.Name);
            if (userWhosRatingId == userId)
            {
                return Forbid("You cant rate yourself, you silly goose!");
            }
            var ratingEntity = new Rating()
            {
                Value = userRatingDto.Value,
                UserId = userId
            };
            _repository.Account.AddRating(ratingEntity);
            _repository.Save();
            return Ok();
        }
    }
}
