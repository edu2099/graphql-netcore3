using GraphQL;
using GraphQLDotNetCore.GraphQL.Queries;
using GraphQLTypes = GraphQL.Types;

namespace GraphQLDotNetCore.GraphQL.Schema
{
    public class AppSchema : GraphQLTypes.Schema
    {
        public AppSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<Query>();
        }
    }
}
