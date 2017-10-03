namespace CurriculumVitae.Types
{
    /// <summary>
    /// <see cref="Education"/> represents an education and the institution where the education has taken place.
    /// </summary>
    public class Education
    {
        public int Id { get; }
        public string Name { get; }
        public string Institution { get; }

        public Education(int id, string name, string institution)
        {
            Id = id;
            Name = name;
            Institution = institution;
        }
    }
}
