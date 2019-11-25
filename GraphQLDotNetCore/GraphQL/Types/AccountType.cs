using GraphQL.Types;
using GraphQLDotNetCore.Contracts;
using GraphQLDotNetCore.Entities;

namespace GraphQLDotNetCore.GraphQL
{
    public class AccountType : ObjectGraphType<Account>
    {
        public AccountType(IOwnerRepository ownerRepository)
        {
            Field(x => x.Id, type: typeof(IdGraphType));
            Field<TypeOfAccountEnumType>("accountType", resolve: context => context.Source.Type);
            Field(x => x.Description);
            Field<OwnerType>("owner", resolve: context => ownerRepository.Get(context.Source.OwnerId));
        }
    }
}
