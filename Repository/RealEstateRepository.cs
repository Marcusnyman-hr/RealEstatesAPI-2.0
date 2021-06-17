using Contracts;
using Entities;
using Entities.Models;
using Helpers;
using Helpers.ResourceParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RealEstateRepository : RepositoryBase<RealEstate>, IRealEstateRepository
    {
        public RealEstateRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
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
    }
}
