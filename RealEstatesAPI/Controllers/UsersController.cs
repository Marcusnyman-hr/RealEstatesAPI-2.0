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
        /// <summary>
        /// Get stats for user
        /// </summary>
        /// <remarks>
        /// Retrieves all available stats for a certain user by provided username
        /// </remarks>
        /// <returns>
        /// </returns>
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
            var userToSend = new UserDto
            {
                UserName = username,
                RealEstates = amountOfRealEstates,
                Comments = commentsByUserId,
                Rating = avgRating
            };

            return Ok(userToSend) ;
        }
        /// <summary>
        /// Rate a user
        /// </summary>
        /// <remarks>
        /// Rate a user with a value from 1-5
        /// </remarks>
        /// <returns>
        /// </returns>
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

        /// <summary>
        /// Get stats for user
        /// </summary>
        /// <remarks>
        /// rate a user by ther username
        /// </remarks>
        /// <returns>
        /// </returns>
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
                return StatusCode(403);
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
