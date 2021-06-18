using Contracts;
using Entities;
using Entities.Models;
using Helpers;
using Helpers.ResourceParameters;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Repository
{
    public class RealEstateRepository : RepositoryBase<RealEstate>, IRealEstateRepository
    {
        public RealEstateRepository(RepositoryContext repositoryContext, IHostingEnvironment environment)
            : base(repositoryContext, environment)
        {
        }
        public IEnumerable<RealEstate> GetAllRealEstates(bool trackChanges, SkipAndTakeRP skipAndTakeRP) 
        {
            if(skipAndTakeRP == null)
            {
                throw new ArgumentNullException(nameof(skipAndTakeRP));
            }
            var realEstates = 
            FindAll(trackChanges)
            .OrderBy(c => c.CreatedOn).
            ToList();
            skipAndTakeRP = HelperFunctions.ValidateAndCorrectSkipAndTake(skipAndTakeRP);
            return realEstates.Skip(skipAndTakeRP.Skip).Take(skipAndTakeRP.Take);
        }

        public RealEstate GetRealEstate(bool trackChanges, Guid realEstateId) =>
            FindByCondition(re => re.Id.Equals(realEstateId), trackChanges)
            .SingleOrDefault();
        public bool RealEstateExists(bool trackChanges, Guid realEstateId) =>
            FindByCondition(re => re.Id.Equals(realEstateId), trackChanges)
            .Any();

        public void CreateRealEstate(RealEstate realEstate) => Create(realEstate);

        public int GetAmountOfRealEstatesByUser(string userId)
        {
            return RepositoryContext.RealEstates.Where(re => re.UserId == Guid.Parse(userId)).Count();
        }

        public RealEstateType GetRealEstateTypeById(int realEstateTypeId)
        {
            return RepositoryContext.RealEstateTypes.Where(ret => ret.Id == realEstateTypeId).FirstOrDefault();
        }

        public async Task<string> UploadImage(FileUpload file)
        {
            if (file != null)
            {
                try
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\uploads\\"))
                    {
                        Directory.CreateDirectory(_environment.WebRootPath + "\\uploads\\");
                    }
                    string fileEnding = Path.GetExtension(file.File.FileName);
                    string newFileName = HelperFunctions.RandomString(16) + fileEnding;
                    using (FileStream filestream = System.IO.File.Create(_environment.WebRootPath + "\\uploads\\" + newFileName))
                    {
                        file.File.CopyTo(filestream);
                        filestream.Flush();
                        return "/uploads/" + newFileName;
                    }
                }
                catch (Exception ex)
                {
                    return "";
                }
            }
            return "";
        }

        public void UpdateRealEstate(RealEstate realEstate) => Update(realEstate);

        public IEnumerable<RealEstate> GetAllRealEstatesByUsername(bool trackChanges, string username) =>
            FindByCondition(re=>re.UserName == username, trackChanges)
            .OrderBy(c => c.CreatedOn).
            ToList();
    }
}
