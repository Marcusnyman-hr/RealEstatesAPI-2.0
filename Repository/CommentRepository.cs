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

        public void CreateComment(Comment comment) => Create(comment);

        public Comment GetComment(Guid commentId, bool trackChanges) =>
            FindByCondition(c => c.Id.Equals(commentId), trackChanges)
            .FirstOrDefault();

        public IEnumerable<Comment> GetComments(Guid realEstateId, bool trackChanges) =>
            FindByCondition(c => c.RealEstateId.Equals(realEstateId), trackChanges)
            .OrderBy(c => c.CreatedOn);

        public IEnumerable<Comment> GetCommentsByUserId(Guid userId, bool trackChanges) =>
            FindByCondition(c => c.UserId.Equals(userId), trackChanges)
            .OrderBy(c => c.CreatedOn);

    }
}
