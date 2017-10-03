using CurriculumVitae.Repositories;
using CurriculumVitae.Types;
using GraphQL.Types;

namespace CurriculumVitae.GraphQL.Types
{
    public class SkillType : ObjectGraphType<Skill>
    {
        public SkillType(ICurriculumVitaeRepository repository)
        {
            Name = "Skill";

            Field(t => t.Id).Description("Id of the skill");
            Field(t => t.Name).Description("Name of the skill");
            Field<SkillLevelType>("level", "User's proficiency of the skill");
            Field<ListGraphType<ProjectType>>("usedOnProjects", "Projects where the skills have been used",
                resolve: context => repository.GetProjectsWhereSkillWasUsed(context.Source.Id));
            Field<ListGraphType<CompanyType>>("usedInCompanies", "Companies where the skills have been used",
                resolve: context => repository.GetCompaniesWhereSkillWasUsed(context.Source.Id));
        }
    }
}
