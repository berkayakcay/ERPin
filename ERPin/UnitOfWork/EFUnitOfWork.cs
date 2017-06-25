using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERPin.Models;
using ERPin.Repositories;

namespace ERPin.UnitOfWork
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly ERPinDbContext _dbContext;

        public EfUnitOfWork(ERPinDbContext dbContext)
        {
            Database.SetInitializer<ERPinDbContext>(null);
            if (dbContext == null)
            {
                throw new ArgumentNullException("dbContext can not be null");
            }

            _dbContext = dbContext;

            //_dbContext.Configuration.LazyLoadingEnabled = false;
            //_dbContext.Configuration.ValidateOnSaveEnabled = false;
            //_dbContext.Configuration.ProxyCreationEnabled = false;
        }


        public IRepository<T> GetRepository<T>() where T : class
        {
            return new EfRepository<T>(_dbContext);
        }


        public int SaveChanges()
        {
            try
            {
                // Transaction operation can be handle here or, you can use Identity Map design pattern.
                return _dbContext.SaveChanges();
            }
            catch (Exception)
            {
                // DbEntityValidationException errors can be handle here.
                throw;
            }
        }


        /// <summary>
        /// Dispose
        /// </summary>
        private bool _disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this._disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }

            this._disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
