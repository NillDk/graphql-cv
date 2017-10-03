using System;
using Microsoft.AspNetCore.Http;

namespace CurriculumVitae.Web
{
    public class GraphQLSettings
    {
        public PathString Path { get; set; } = "/graphql";
        public Func<HttpContext, object> BuildUserContext { get; set; }
    }
}