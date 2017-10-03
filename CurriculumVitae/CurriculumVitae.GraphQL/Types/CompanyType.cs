using CurriculumVitae.Repositories;
using CurriculumVitae.Types;
using GraphQL.Types;

namespace CurriculumVitae.GraphQL.Types
{
    public class CompanyType : ObjectGraphType<Company>
    {
        public CompanyType(ICurriculumVitaeRepository repository)
        {
            Name = "Company";

            Field(t => t.Id).Description("Id of the company");
            Field(t => t.Name).Description("Name of the company");
            Field<ListGraphType<ProjectType>>("projects", "Projects made in the company",
                resolve: context => repository.GetProjectsMadeInCompany(context.Source.Id));
            Field<ListGraphType<SkillType>>("skillsUsed", "Skills used accross projects in the company",
                resolve: context => repository.GetSkillsUsedInCompany(context.Source.Id));
        }
    }
}
