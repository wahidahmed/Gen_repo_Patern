using Gen_Repo_Pattern.DAL.Entities;
using Gen_Repo_Pattern.DAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gen_Repo_Pattern.DAL.UnitOfWorks.Interfaces
{
    public interface IUnitOfWork: IDisposable
    {
        IRepository<Customer> Customers { get; }
        void Commit();
    }
}
