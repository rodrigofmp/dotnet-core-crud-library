using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Core.Repository
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
