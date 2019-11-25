using GraphQL.Types;
using GraphQLDotNetCore.Entities;

namespace GraphQLDotNetCore.GraphQL
{
    public class TypeOfAccountEnumType : EnumerationGraphType<TypeOfAccount>
    {
        public TypeOfAccountEnumType()
        {
            Name = "TypeOfAccountType";
        }
    }
}