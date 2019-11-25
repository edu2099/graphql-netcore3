using System;
using System.Linq;
using System.Collections.Generic;
using GraphQLDotNetCore.Contracts;
using GraphQLDotNetCore.Entities;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GraphQLDotNetCore.Repository
{
    public class Repository <T>: IRepository<T> where T: Entity
    {
        protected readonly ApplicationContext context;

        public Repository(ApplicationContext context)
        {
            this.context = context;
        }

        public T Get(Guid id) => context.Set<T>().FirstOrDefault(x => x.Id.Equals(id));

        public IQueryable<T> GetAll() => context.Set<T>().AsQueryable();
    }
}
