using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using WebAPI.DAL.Repository.IRepository;
using WebAPI.Entities;

namespace WebAPI.DAL.Repository
{
    internal class BlogRepository : RepositoryBase,IBlogRepository
    {
        public BlogRepository(IDbTransaction transaction):base(transaction)
        {

        }
        public IEnumerable<Blog> GetAll()
        {
            return this.List<Blog>("Getall");    
        }
        
    }
}
