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
        [HttpGet("/comment/{commentId}", Name = "GetComment")]
        public ActionResult<CommentDto> GetComment(string commentId)
        {
            var commentFromRepo =_repository.Comment.GetComment(Guid.Parse(commentId), trackChanges: false);
            return Ok(_mapper.Map<CommentDto>(commentFromRepo));
        }
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
