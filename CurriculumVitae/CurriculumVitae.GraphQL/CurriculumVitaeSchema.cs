using GraphQL;
using GraphQL.Types;

namespace CurriculumVitae.GraphQL
{
    public class CurriculumVitaeSchema : Schema
    {
        public CurriculumVitaeSchema(FuncDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<CurriculumVitaeQuery>();
        }
    }
}
