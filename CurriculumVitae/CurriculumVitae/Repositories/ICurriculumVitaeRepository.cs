using CurriculumVitae.Types;
using System.Collections.Generic;

namespace CurriculumVitae.Repositories
{
    public interface ICurriculumVitaeRepository
    {
        IReadOnlyList<Company> GetCompanies();
        Company GetCompanyById(int id);
        Company GetCompanyWhereProjectWasMade(int projectId);
        IReadOnlyList<Company> GetCompaniesWhereSkillWasUsed(int skillId);

        IReadOnlyList<Education> GetEducations();
        Education GetEducationById(int id);

        IReadOnlyList<Project> GetProjects();
        Project GetProjectById(int id);
        IReadOnlyList<Project> GetProjectsWhereSkillWasUsed(int skillId);
        IReadOnlyList<Project> GetProjectsMadeInCompany(int companyId);

        IReadOnlyList<Skill> GetSkills();
        Skill GetSkillById(int id);
        IReadOnlyList<Skill> GetSkillsUsedOnProject(int projectId);
        IReadOnlyList<Skill> GetSkillsUsedInCompany(int companyId);
    }
}
