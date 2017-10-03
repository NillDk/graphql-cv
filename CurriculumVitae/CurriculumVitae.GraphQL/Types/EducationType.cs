using CurriculumVitae.Types;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace CurriculumVitae.GraphQL.Types
{
    public class EducationType : ObjectGraphType<Education>
    {
        public EducationType()
        {
            Name = "Education";

            Field(t => t.Id).Description("Id of the education");
            Field(t => t.Name).Description("Name of the education");
            Field(t => t.Institution).Description("Name of the instutution where the education took place");
        }
    }
}
