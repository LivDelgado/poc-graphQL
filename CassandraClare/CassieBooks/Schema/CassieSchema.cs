using GraphQL;

namespace CassandraClareBooks.Schema
{
    public class CassieSchema : GraphQL.Types.Schema
    {
        public CassieSchema(CassieQuery query, IDependencyResolver resolver)
        {
            Query = query;
            DependencyResolver = resolver;
        }
    }
}
