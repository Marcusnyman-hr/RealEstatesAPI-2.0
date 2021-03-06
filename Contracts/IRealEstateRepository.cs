using Entities.Models;
using Helpers.ResourceParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRealEstateRepository
    {
        IEnumerable<RealEstate> GetAllRealEstates(bool trackChanges, SkipAndTakeRP skipAndTakeRP);
        IEnumerable<RealEstate> GetAllRealEstatesByUsername(bool trackChanges, string username);
        RealEstate GetRealEstate(bool trackChanges, Guid realEstateId);
        void CreateRealEstate(RealEstate realEstate);
        bool RealEstateExists(bool trackChanges, Guid realEstateId);
        int GetAmountOfRealEstatesByUser(string userId);
        RealEstateType GetRealEstateTypeById(int realEstateTypeId);
        Task<string> UploadImage(FileUpload file);
        void UpdateRealEstate(RealEstate realEstate);
    }
}
