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

        public IEnumerable<Comment> GetCommentsForRealEstate(bool trackChanges, Guid realEstateId, SkipAndTakeRP skipAndTakeRP)
        {
            if (skipAndTakeRP == null)
            {
                throw new ArgumentNullException(nameof(skipAndTakeRP));
            }
            skipAndTakeRP = HelperFunctions.ValidateAndCorrectSkipAndTake(skipAndTakeRP);
            var comments = FindByCondition(c => c.RealEstateId.Equals(realEstateId), trackChanges)
             .OrderBy(c => c.CreatedOn).Skip(skipAndTakeRP.Skip).Take(skipAndTakeRP.Take);
            return comments;
        }
        public IEnumerable<Comment> GetLatestCommentsForRealEstate(bool trackChanges, Guid realEstateId) =>
            FindByCondition(c => c.RealEstateId.Equals(realEstateId), trackChanges)
             .OrderBy(c => c.CreatedOn).Take(10);
        public IEnumerable<Comment> GetLatestCommentsByUser(bool trackChanges, string username, SkipAndTakeRP skipAndTakeRP)
        {
            if (skipAndTakeRP == null)
            {
                throw new ArgumentNullException(nameof(skipAndTakeRP));
            }
            skipAndTakeRP = HelperFunctions.ValidateAndCorrectSkipAndTake(skipAndTakeRP);
            var comments = FindByCondition(c => c.UserName.Equals(username), trackChanges)
             .OrderBy(c => c.CreatedOn).Skip(skipAndTakeRP.Skip).Take(skipAndTakeRP.Take);
            return comments;
        }


        public IEnumerable<Comment> GetCommentsByUserId(Guid userId, bool trackChanges) =>
            FindByCondition(c => c.UserId.Equals(userId), trackChanges)
            .OrderBy(c => c.CreatedOn);


    }
}
