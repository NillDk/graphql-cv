using System.Security.Claims;

namespace CurriculumVitae.Web
{
    public class GraphQLUserContext
    {
        public ClaimsPrincipal User { get; set; }
    }
}
