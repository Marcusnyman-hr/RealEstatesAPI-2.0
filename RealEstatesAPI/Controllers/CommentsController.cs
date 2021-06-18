using AutoMapper;
using Contracts;
using Entities.Models;
using Helpers.ResourceParameters;
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
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public CommentsController(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        /// <summary>
        /// Retrieves comments for realestate
        /// </summary>
        /// <remarks>
        /// Retrieves all comments (caps at 100) for a specific realestate by provided realestate Id
        /// Also accepts skip and take parameters
        /// all results are ordered on creation date
        /// </remarks>
        /// <returns>
        /// </returns>
        [HttpGet("{realEstateId}")]
        public ActionResult<IEnumerable<CommentDto>> GetCommentsForRealEstate(string realEstateId, [FromQuery] SkipAndTakeRP skipAndTakeRP)
        {
            var guidFromRealEstateId = Guid.Parse(realEstateId);
            var realEstateExists = _repository.RealEstate.RealEstateExists(trackChanges: false, guidFromRealEstateId);
            if(!realEstateExists)
            {
                return NotFound("Real Estate does not exist");
            }
            var commentsFromRepo = _repository.Comment.GetCommentsForRealEstate(trackChanges: false, Guid.Parse(realEstateId), skipAndTakeRP);
            if (commentsFromRepo == null)
            {
                return NotFound();
            }
            return Ok(_mapper.Map<IEnumerable<CommentDto>>(commentsFromRepo));
        }
        /// <summary>
        /// Retrieves a specific comment
        /// </summary>
        /// <remarks>
        /// Retrieves specific comment by the provided commentId
        /// </remarks>
        /// <returns>
        /// </returns>
        [HttpGet("/comment/{commentId}", Name = "GetComment")]
        public ActionResult<CommentDto> GetComment(string commentId)
        {
            var commentFromRepo =_repository.Comment.GetComment(Guid.Parse(commentId), trackChanges: false);
            return Ok(_mapper.Map<CommentDto>(commentFromRepo));
        }
        /// <summary>
        /// Retrieves all comments by user
        /// </summary>
        /// <remarks>
        /// Retrieves all comments by a specific user (caps at 100)
        /// also accepts skip and take parameters
        /// all results are ordered on creation date.
        /// </remarks>
        /// <returns>
        /// </returns>
        [HttpGet("byuser/{userName}", Name = "GetCommentsByUser")]
        public ActionResult<IEnumerable<CommentDto>> GetCommentsByUser(string userName, [FromQuery] SkipAndTakeRP skipAndTakeRP)
        {
            if(!_repository.Account.UserExists(userName).Result)
            {
                return NotFound();
            }
            var commentsFromRepo = _repository.Comment.GetLatestCommentsByUser(trackChanges: false, userName, skipAndTakeRP);
            return Ok(_mapper.Map<IEnumerable<CommentDto>>(commentsFromRepo));
        }
        /// <summary>
        /// Creates a new comment 
        /// </summary>
        /// <remarks>
        /// Creates a new comment for a specific realestate
        /// Example body:
        /// {
        ///    "Content": "It's a trap! Don't go there!",
        ///     "UserName": "somerandomguy",
        ///     "CreatedOn": "2015-11-22T16:25:49.29"
        /// }
    /// </remarks>
    /// <returns>
    /// </returns>
    [HttpPost]
        public ActionResult<CommentDto> PostComment(CreateCommentDto comment)
        {
            var username = User.Identity.Name;
            var userId = _repository.Account.GetUserIdByUserName(username).Result;
            var commentEntity = _mapper.Map<Comment>(comment);
            commentEntity.UserName = username;
            commentEntity.UserId = Guid.Parse(userId);
            commentEntity.CreatedOn = DateTime.Now;
            _repository.Comment.CreateComment(commentEntity);
            _repository.Save();
            var commentToReturn = _mapper.Map<CommentDto>(commentEntity);
            return CreatedAtRoute("GetComment",
                new { commentId = commentEntity.Id }, commentToReturn);

        }
    }
}
