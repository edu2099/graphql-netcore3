using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLDotNetCore.Contracts
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        T Get(Guid id);
    }
}
