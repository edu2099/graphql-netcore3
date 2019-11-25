using GraphQLDotNetCore.Contracts;
using GraphQLDotNetCore.Entities;

namespace GraphQLDotNetCore.Repository
{
    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        public AccountRepository(ApplicationContext context)
            : base(context)
        {
        }
    }
}
