using System;
using FBC.Northwind.Data.Context;
using FBC.Northwind.RepositoryInterfaces;

namespace FBC.Northwind.Data.UnitOfWOrk
{
    public class MusicStoreUnitOfWork : IUnitOfWork
    {
        private readonly IDbContextFactory _contextFactory;
        private MusicStoreDbContext _context;

        public MusicStoreUnitOfWork(IDbContextFactory contextFactory)
        {
            if (contextFactory == null)
            {
                throw new ArgumentNullException("contextFactory");
            }

            _contextFactory = contextFactory;
        }

        protected MusicStoreDbContext Context
        {
            get { return _context ?? (_context = _contextFactory.Get()); }
        }

        public void SaveChanges()
        {
            Context.Commit();
        }
    }
}