namespace CurriculumVitae.Types
{
    /// <summary>
    /// <see cref="Skill"/> represents a specific knowledge a user posesses.
    /// </summary>
    public class Skill
    {
        public int Id { get; }
        public string Name { get; }
        public SkillLevel Level { get; }

        public Skill(int id, string name, SkillLevel level)
        {
            Id = id;
            Name = name;
            Level = level;
        }
    }
}