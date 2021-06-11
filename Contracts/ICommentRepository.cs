﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetComments(Guid realEstateId, bool trackChanges);
        IEnumerable<Comment> GetCommentsByUserId(Guid userId, bool trackChanges);
    }
}