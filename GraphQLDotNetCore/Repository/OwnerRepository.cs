using System;
using System.Linq;
using System.Collections.Generic;
using GraphQLDotNetCore.Contracts;
using GraphQLDotNetCore.Entities;

namespace GraphQLDotNetCore.Repository
{
    public class OwnerRepository : Repository<Owner>, IOwnerRepository
    {
        public OwnerRepository(ApplicationContext context)
            : base(context)
        { 
        }
    }
}
