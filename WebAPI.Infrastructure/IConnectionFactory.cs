using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace WebAPI.Infrastructure
{
    public interface IConnectionFactory
    {
        public IDbConnection GetConnection { get; }
    }
}
