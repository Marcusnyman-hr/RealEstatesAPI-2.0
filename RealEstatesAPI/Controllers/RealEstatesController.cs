using AutoMapper;
using Contracts;
using Helpers.ResourceParameters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstatesAPI.DTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RealEstatesAPI.Controllers
{
    //[Authorize]
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
        [HttpGet("{realEstateId}")]
        public IActionResult GetRealEstate(Guid realEstateId)
        {
            var realEstateFromRepo = _repository.RealEstate.GetRealEstate(trackChanges: false, realEstateId);
            if(realEstateFromRepo == null)
            {
                return NotFound();
            }
            var commentsFromRepo = _repository.Comment.GetComments(realEstateId, trackChanges: false);
            realEstateFromRepo.Comments = commentsFromRepo.ToList();
            return Ok(_mapper.Map<AuthorizedRealEstateDto>(realEstateFromRepo));
        }
        //Authorized
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
