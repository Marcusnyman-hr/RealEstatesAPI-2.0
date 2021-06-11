using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IRepositoryManager
    {
        IRealEstateRepository RealEstate { get; }
        ICommentRepository Comment { get; }
        IAccountRepository Account { get; }
        void Save();
    }
}
