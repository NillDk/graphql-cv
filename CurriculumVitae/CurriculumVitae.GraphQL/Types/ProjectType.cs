using CurriculumVitae.Repositories;
using CurriculumVitae.Types;
using GraphQL.Types;

namespace CurriculumVitae.GraphQL.Types
{
    public class ProjectType : ObjectGraphType<Project>
    {
        public ProjectType(ICurriculumVitaeRepository repository)
        {
            Name = "Project";

            Field(t => t.Id).Description("Id of the project");
            Field(t => t.Name).Description("Name of the project");
            Field<CompanyType>("company", "Company where the project took place",
                resolve: context => repository.GetCompanyById(context.Source.CompanyId));
            Field<ListGraphType<SkillType>>("skillsUsed", "Skills used on the project",
                resolve: context => repository.GetSkillsUsedOnProject(context.Source.Id));
        }
    }
}
