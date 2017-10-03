using CurriculumVitae.GraphQL.Types;
using CurriculumVitae.Repositories;
using GraphQL.Types;

namespace CurriculumVitae.GraphQL
{
    public class CurriculumVitaeQuery : ObjectGraphType<object>
    {
        public CurriculumVitaeQuery(ICurriculumVitaeRepository repository)
        {
            Name = "root";

            Field<ListGraphType<CompanyType>>(
                "companies",
                "Companies the user has worked for",
                resolve: context => repository.GetCompanies());

            Field<CompanyType>(
                "company",
                "Specific company the user has worked for",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "Id of the company" }),
                resolve: context => repository.GetCompanyById(context.GetArgument<int>("id")));

            Field<ListGraphType<EducationType>>(
                "educations",
                "Educations the user has acquired",
                resolve: context => repository.GetEducations());

            Field<EducationType>(
                "education",
                "Specific education the user has acquired",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "Id of the education" }),
                resolve: context => repository.GetEducationById(context.GetArgument<int>("id")));

            Field<ListGraphType<ProjectType>>(
                "projects",
                "Projects the user has participated in",
                resolve: context => repository.GetProjects());

            Field<ProjectType>(
                "project",
                "Specific project the user has participated in",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "Id of the project" }),
                resolve: context => repository.GetProjectById(context.GetArgument<int>("id")));

            Field<ListGraphType<SkillType>>(
                "skills",
                "Skills the user has aquired during his work life",
                resolve: context => repository.GetSkills());

            Field<SkillType>(
                "skill",
                "Specific skill the user has acquired during his work life",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<IntGraphType>> { Name = "id", Description = "Id of the skill" }),
                resolve: context => repository.GetSkillById(context.GetArgument<int>("id")));
        }
    }
}
