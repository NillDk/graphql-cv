using CurriculumVitae.Repositories;
using CurriculumVitae.Types;
using GraphQL.Types;

namespace CurriculumVitae.GraphQL.Types
{
    public class SkillLevelType : EnumerationGraphType<SkillLevel>
    {
        public SkillLevelType(ICurriculumVitaeRepository repository)
        {
            Name = "SkillLevel";
            Description = "User's proficiency of a skill.";

            AddValue("Beginner", "Beginner proficiency", SkillLevel.Beginner);
            AddValue("Intermediate", "Intermediate proficiency", SkillLevel.Intermediate);
            AddValue("Expert", "Expert proficiency", SkillLevel.Expert);
        }
    }
}
