using System;
using System.Collections.Generic;
using System.Text;
using WebAPI.DAL.Repository.IRepository;

namespace WebAPI.DAL
{
    public interface IUnitOfWork
    {
        //Define Repository Interface Property
        IBlogRepository BlogRepository { get; }
        void Commit();
    }
}
