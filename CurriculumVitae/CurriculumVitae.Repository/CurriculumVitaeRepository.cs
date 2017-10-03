using System.Collections.Generic;
using System.Linq;
using CurriculumVitae.Repositories;
using CurriculumVitae.Types;

namespace CurriculumVitae.Repository
{
    public class CurriculumVitaeRepository : ICurriculumVitaeRepository
    {
        #region Data
        private readonly Company[] _companies = new[]
        {
            new Company(1, "Unik System Design"),
            new Company(2, "Spain-Holiday"),
            new Company(3, "DFF-EDB"),
        };

        private readonly Education[] _educations = new[]
        {
            new Education(1, "HHX", "Morsø Handelsgymnasium"),
            new Education(2, "Datamatiker", "Skive EDB Skole")
        };

        private readonly Project[] _projects = new[]
        {
            new Project(1, 1, "Sikkerhedsmodul", new[] { 1 }),
            new Project(2, 2, "Integration til Reviso", new[] { 2 }),
            new Project(3, 2, "Bookingsystem", new[] { 2, 3 }),
            new Project(4, 3, "Login på flere klienter", new[] { 2, 3 }),
        };

        private readonly Skill[] _skills = new[]
        {
            new Skill(1, "Delphi", SkillLevel.Intermediate),
            new Skill(2, "C#", SkillLevel.Expert),
            new Skill(3, "AngularJS", SkillLevel.Expert)
        };
        #endregion

        public IReadOnlyList<Company> GetCompanies() =>
            _companies.ToList();

        public Company GetCompanyById(int id) =>
            _companies.FirstOrDefault(c => c.Id == id);

        public IReadOnlyList<Education> GetEducations() =>
            _educations.ToList();

        public Education GetEducationById(int id) =>
            _educations.FirstOrDefault(e => e.Id == id);

        public IReadOnlyList<Project> GetProjects() =>
            _projects.ToList();

        public Project GetProjectById(int id) =>
            _projects.FirstOrDefault(p => p.Id == id);

        public IReadOnlyList<Skill> GetSkills() =>
            _skills.ToList();

        public Skill GetSkillById(int id) =>
            _skills.FirstOrDefault(s => s.Id == id);

        public IReadOnlyList<Skill> GetSkillsUsedOnProject(int projectId) =>
            _skills.Where(s => _projects.Any(p => p.Id == projectId && p.SkillIds.Contains(s.Id))).ToList();

        public IReadOnlyList<Skill> GetSkillsUsedInCompany(int companyId) =>
            _skills.Where(s => _projects.Any(p => p.CompanyId == companyId && p.SkillIds.Contains(s.Id))).ToList();

        public IReadOnlyList<Project> GetProjectsWhereSkillWasUsed(int skillId) =>
            _projects.Where(p => p.SkillIds.Contains(skillId)).ToList();

        public IReadOnlyList<Project> GetProjectsMadeInCompany(int companyId) =>
            _projects.Where(p => p.CompanyId == companyId).ToList();

        public Company GetCompanyWhereProjectWasMade(int projectId) =>
            _companies.FirstOrDefault(c => _projects.Any(p => p.Id == projectId && p.CompanyId == c.Id));

        public IReadOnlyList<Company> GetCompaniesWhereSkillWasUsed(int skillId) =>
            _companies.Where(c => _projects.Any(p => p.CompanyId == c.Id && p.SkillIds.Contains(skillId))).ToList();
    }
}
