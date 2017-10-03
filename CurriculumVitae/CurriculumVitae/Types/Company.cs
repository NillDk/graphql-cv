namespace CurriculumVitae.Types
{
    /// <summary>
    /// <see cref="Company"/> represents a company the user has worked for.
    /// </summary>
    public class Company
    {
        public int Id { get; }
        public string Name { get; }

        public Company(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
