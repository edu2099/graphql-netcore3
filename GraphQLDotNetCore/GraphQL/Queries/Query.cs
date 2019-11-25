using GraphQLDotNetCore.Contracts;
using GraphQL.Types;

namespace GraphQLDotNetCore.GraphQL.Queries
{
    public partial class Query: ObjectGraphType
    {
        private readonly IOwnerRepository ownerRepository;
        private readonly IAccountRepository accountRepository;

        public Query(
            IOwnerRepository ownerRepository,
            IAccountRepository accountRepository
        ) {
            this.ownerRepository = ownerRepository;
            this.accountRepository = accountRepository;

            AddOwnerQueries();
            AddAccountQueries();
        }
    }
}
