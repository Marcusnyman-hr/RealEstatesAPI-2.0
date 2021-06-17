using Entities.Models;
using Helpers.ResourceParameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ICommentRepository
    {
        Comment GetComment(Guid commentId, bool trackChanges);
        IEnumerable<Comment> GetCommentsForRealEstate(bool trackChanges, Guid realEstateId, SkipAndTakeRP skipAndTakeRP);
        IEnumerable<Comment> GetLatestCommentsForRealEstate(bool trackChanges, Guid realEstateId);
        public IEnumerable<Comment> GetLatestCommentsByUser(bool trackChanges, string username, SkipAndTakeRP skipAndTakeRP);
        IEnumerable<Comment> GetCommentsByUserId(Guid userId, bool trackChanges);
        void CreateComment(Comment comment);
    }
}
