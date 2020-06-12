using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Entities;

namespace WebAPI.DAL.Repository.IRepository
{
    public interface IBlogRepository
    {
      IEnumerable<Blog> GetAll();
    }
}
