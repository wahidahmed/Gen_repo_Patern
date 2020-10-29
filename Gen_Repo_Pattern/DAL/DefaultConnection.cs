using Gen_Repo_Pattern.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Gen_Repo_Pattern.DAL
{
    public class DefaultConnection:DbContext
    {
        public DbSet<Customer> customers { get; set; }
    }
}