using Gen_Repo_Pattern.DAL.Entities;
using Gen_Repo_Pattern.DAL.Repositories;
using Gen_Repo_Pattern.DAL.Repositories.Interfaces;
using Gen_Repo_Pattern.DAL.UnitOfWorks.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Gen_Repo_Pattern.DAL.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private DefaultConnection _dbContext;
        private BaseRepository<Customer> _customers;

        public UnitOfWork(DefaultConnection dbContext)
        {
            _dbContext = dbContext;
        }
        public IRepository<Customer> Customers
        {
            get
            {
                return _customers ??
                    (_customers = new BaseRepository<Customer>(_dbContext));
            }
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }


        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _dbContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        //call the following method in the bottom of every controller where the unitofwork is called
        //protected override void Dispose(bool disposing)
        //{
        //    unitOfWork.Dispose();
        //    base.Dispose(disposing);
        //}
    }
}