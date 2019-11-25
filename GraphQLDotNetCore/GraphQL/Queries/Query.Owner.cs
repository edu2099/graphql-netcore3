using System;
using GraphQL.Types;

namespace GraphQLDotNetCore.GraphQL.Queries
{
    //Owner Query
    public partial class Query
    {
        public void AddOwnerQueries()
        {
            Field<ListGraphType<OwnerType>>(
                "owners",
                resolve: context => ownerRepository.GetAll()
            );

            Field<OwnerType>(
                "owner",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IdGraphType>> { Name = "id" }
                ),
                resolve: context => ownerRepository.Get(context.GetArgument<Guid>("id"))
            );
        }
    }
}