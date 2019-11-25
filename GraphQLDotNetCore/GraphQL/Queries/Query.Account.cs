using System;
using GraphQL.Types;

namespace GraphQLDotNetCore.GraphQL.Queries
{
    //Account Query
    public partial class Query
    {
        public void AddAccountQueries()
        {
            Field<ListGraphType<AccountType>>(
                "accounts",
                resolve: context => accountRepository.GetAll()
            );

            Field<AccountType>(
                "account",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }
                ),
                resolve: context => accountRepository.Get(context.GetArgument<Guid>("id"))
            );
        }
    }
}