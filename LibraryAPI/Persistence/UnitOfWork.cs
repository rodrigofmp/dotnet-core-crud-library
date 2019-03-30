using LibraryAPI.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryAPI.Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly LibraryContext context;

        public UnitOfWork(LibraryContext context)
        {
            this.context = context;
        }

        public async Task CompleteAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
