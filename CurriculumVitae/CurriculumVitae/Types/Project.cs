namespace CurriculumVitae.Types
{
    /// <summary>
    /// <see cref="Project"/> represents an assignment the user has worked on.
    /// </summary>
    public class Project
    {
        public int Id { get; }
        
        /// <summary>
        /// Id of the company where the project took place.
        /// </summary>
        public int CompanyId { get; }

        public string Name { get; }

        public int[] SkillIds { get; }

        public Project(int id, int companyId, string name, int[] skillIds)
        {
            Id = id;
            CompanyId = companyId;
            Name = name;
            SkillIds = skillIds;
        }
    }
}
