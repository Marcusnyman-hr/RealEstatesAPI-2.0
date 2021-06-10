using Contracts;
using Entities;
using Entities.Models;
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
            if (skipAndTakeRP.Take > 100) skipAndTakeRP.Take = 100;
            if (skipAndTakeRP.Skip == 0 && skipAndTakeRP.Take == 0)
            {
                return realEstates.Take(10);
            }
            return realEstates.Skip(skipAndTakeRP.Skip).Take(skipAndTakeRP.Take);
        }

        public RealEstate GetRealEstate(bool trackChanges, Guid realEstateId) =>
            FindByCondition(re => re.Id.Equals(realEstateId), trackChanges)
            .SingleOrDefault();
    }
}
