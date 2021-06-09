using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private IRealEstateRepository _realEstateRepository;
        private ICommentRepository _commentRepository;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public IRealEstateRepository RealEstate
        {
            get
            {
                if (_realEstateRepository == null)
                    _realEstateRepository = new RealEstateRepository(_repositoryContext);
                return _realEstateRepository;
            }
        }

        public ICommentRepository Comment
        {
            get
            {
                if (_commentRepository == null)
                    _commentRepository = new CommentRepository(_repositoryContext);
                return _commentRepository;
            }
        }

        public void Save() => _repositoryContext.SaveChanges();
    }
}
