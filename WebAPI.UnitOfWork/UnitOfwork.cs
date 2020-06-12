using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Repositories;
using WebAPI.Repositories.EntityRepositories;
using WebAPI.Services;

namespace WebAPI.UnitOfWork
{
    public class UnitOfwork : IUnitOfWork
    {
        private readonly ApplicationDbContext _DbContext;

        public UnitOfwork(ApplicationDbContext applicationDbContext)
        {
            _DbContext = applicationDbContext;
            _blogRepository = new BlogRepository();
        }

        public IBlogRepository _blogRepository { get; private set; }

        public void Dispose()
        {
            _DbContext.Dispose();
        }

        public void SaveChanges()
        {
            _DbContext.SaveChanges();
        }
    }
}
