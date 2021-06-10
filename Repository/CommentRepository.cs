using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CommentRepository : RepositoryBase<Comment>, ICommentRepository
    {
        public CommentRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Comment> GetComments(Guid realEstateId, bool trackChanges) =>
            FindByCondition(c => c.RealEstateId.Equals(realEstateId), trackChanges)
            .OrderBy(c => c.CreatedOn);
    }
}
