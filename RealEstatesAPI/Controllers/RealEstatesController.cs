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
    public class RealEstatesController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly IMapper _mapper;
        public RealEstatesController(IRepositoryManager repository, IMapper mapper)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        [AllowAnonymous]
        [HttpGet]
        public ActionResult<IEnumerable<RealEstateForListDto>> GetRealEstates([FromQuery] SkipAndTakeRP skipAndTakeRP) 
        {
            var realEstatesFromRepo = _repository.RealEstate.GetAllRealEstates(trackChanges: false, skipAndTakeRP);
            if(realEstatesFromRepo == null)
            {
                return NoContent();
            }
            return Ok(_mapper.Map<IEnumerable<RealEstateForListDto>>(realEstatesFromRepo));
        }
        [AllowAnonymous]
        [HttpGet("{realEstateId}", Name ="GetRealEstate")]
        public IActionResult GetRealEstate(Guid realEstateId)
        {
            var realEstateFromRepo = _repository.RealEstate.GetRealEstate(trackChanges: false, realEstateId);
            if(realEstateFromRepo == null)
            {
                return NotFound();
            }

            if (User.Identity.IsAuthenticated)
            {
                var commentsFromRepo = _repository.Comment.GetLatestCommentsForRealEstate(trackChanges: false, realEstateId);
                realEstateFromRepo.Comments = commentsFromRepo.ToList();
                return Ok(_mapper.Map<AuthorizedRealEstateDto>(realEstateFromRepo));
            }
            return Ok(_mapper.Map<RealEstateDto>(realEstateFromRepo));
        }
        [HttpPost]
        public ActionResult<CreatedRealEstateDto> CreateRealEstate([FromBody] CreateRealEstateDto realEstate)
        {
            var userId = _repository.Account.GetUserIdByUserName(User.Identity.Name).Result;
            var realEstateEntity = _mapper.Map<RealEstate>(realEstate);
            realEstateEntity.CreatedOn = DateTime.Now;
            realEstateEntity.UserId = Guid.Parse(userId);
            realEstateEntity.UserName = User.Identity.Name;
            _repository.RealEstate.CreateRealEstate(realEstateEntity);
            _repository.Save();
            var realEstateToReturn = _mapper.Map<CreatedRealEstateDto>(realEstateEntity);
            return CreatedAtRoute("GetRealEstate",
                new { realEstateId = realEstateToReturn.Id }, realEstateToReturn);

        }

        //[HttpGet("{realEstateId}")]
        //public IActionResult GetRealEstate(Guid realEstateId)
        //{
        //    var realEstateFromRepo = _repository.RealEstate.GetRealEstate(trackChanges: false, realEstateId);
        //    if (realEstateFromRepo == null)
        //    {
        //        return NotFound();
        //    }
        //    var commentsFromRepo = _repository.Comment.GetComments(realEstateId, trackChanges: false);
        //    realEstateFromRepo.Comments = commentsFromRepo.ToList();
        //    return Ok(_mapper.Map<AuthorizedRealEstateDto>(realEstateFromRepo));
        //}

    }
}
