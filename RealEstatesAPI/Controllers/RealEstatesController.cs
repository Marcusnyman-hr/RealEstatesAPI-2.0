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
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

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

        /// <summary>
        /// Get all realEstates, can be used with optional skip/take parameters!
        /// </summary>
        /// <remarks>
        /// To get all realestates (caps at a 100) leave skip and take blank
        /// skip=3, take=5 would get the realestate no 4-8 in a list ordered by date when posted
        /// </remarks>
        /// <returns></returns>
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
        /// <summary>
        /// Get all realestates by username
        /// </summary>
        /// <remarks>
        /// Gets all realestates posted by a user, sorted on when they were created.
        /// 
        /// </remarks>
        /// <returns></returns>
        [AllowAnonymous]
        [HttpGet("ByUserName/{username}")]
        public ActionResult<IEnumerable<RealEstateForListDto>> GetRealEstatesByUsername(string username)
        {
            var realEstatesFromRepo = _repository.RealEstate.GetAllRealEstatesByUsername(trackChanges: false, username);
            if (realEstatesFromRepo == null)
            {
                return NoContent();
            }
            return Ok(_mapper.Map<IEnumerable<RealEstateForListDto>>(realEstatesFromRepo));
        }
        /// <summary>
        /// Get a specific RealEstate
        /// </summary>
        /// <remarks>
        /// Gets the specific realestate by providing an Id (guid)
        /// If A valid baerer token is provided, the result will contain comments and contactinfo.
        /// </remarks>
        /// <returns></returns>
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
                var realEstateType = _repository.RealEstate.GetRealEstateTypeById(realEstateFromRepo.RealEstateTypeId);
                var realEstateToReturn = _mapper.Map<AuthorizedRealEstateDto>(realEstateFromRepo);
                realEstateToReturn.RealEstateType = realEstateType.Name;
                return Ok(realEstateToReturn);
            }
            return Ok(_mapper.Map<RealEstateDto>(realEstateFromRepo));
        }
        /// <summary>
        /// Creates a new repository in the database
        /// </summary>
        /// <remarks>
        /// Creates a new realestate in the database by providing a valid json body
        /// Example body:
        ///{
        ///    "Title": "Some very interesting office",
        ///    "Description": "You will love it. The view is great!",
        ///    "Address": "Mladost 1A, Telerik Academy building",
        ///    "Contact": "0888-888-888",
        ///    "ConstructionYear": 2005,
        ///    "SellingPrice": 120000,
        ///    "RentingPrice": 500,
        ///    "Type": 2
        ///}
    /// </remarks>
    /// <returns></returns>
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
        /// <summary>
        /// Uploads a picture file
        /// </summary>
        /// <remarks>
        /// Uploads a picture for a specific realEstate (by id)
        /// 
        /// </remarks>
        /// <returns>
        /// </returns>
        [HttpPost("AddPicture/{realEstateId}")]
        public async Task<IActionResult> AddPicture(Guid realEstateId, [FromForm]FileUpload file)
        {
            var realEstateExists = _repository.RealEstate.RealEstateExists(trackChanges: false, realEstateId);
            if (!realEstateExists)
            {
                return NotFound();
            }
            var realEstateFromRepo = _repository.RealEstate.GetRealEstate(trackChanges: false, realEstateId);
            var imgFilePath = await _repository.RealEstate.UploadImage(file);
            realEstateFromRepo.ImgUrl = imgFilePath;
            _repository.RealEstate.UpdateRealEstate(realEstateFromRepo);
            if(imgFilePath.Length == 0)
            {
                return StatusCode(500);
            }
            _repository.Save();
            return Ok();
        }

    }
}
