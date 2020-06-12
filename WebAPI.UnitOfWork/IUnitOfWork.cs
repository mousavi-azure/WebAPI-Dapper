using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.Repositories;

namespace WebAPI.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        IBlogRepository _blogRepository { get; }

        void SaveChanges();        
    }
}
