using CurriculumVitae.GraphQL;
using CurriculumVitae.GraphQL.Types;
using CurriculumVitae.Repositories;
using CurriculumVitae.Repository;
using GraphQL;
using GraphQL.Http;
using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CurriculumVitae.Web
{
    public static class IoCSetup
    {
        public static void Configure(IServiceCollection services)
        {
            services.AddSingleton<IDocumentExecuter, DocumentExecuter>();
            services.AddSingleton<IDocumentWriter, DocumentWriter>();
            services.AddSingleton<ICurriculumVitaeRepository, CurriculumVitaeRepository>();
            services.AddSingleton<ISchema, CurriculumVitaeSchema>();
            services.AddSingleton<CurriculumVitaeQuery>();
            services.AddSingleton<CompanyType>();
            services.AddSingleton<EducationType>();
            services.AddSingleton<ProjectType>();
            services.AddSingleton<SkillLevelType>();
            services.AddSingleton<SkillType>();
            services.AddSingleton(serviceProvider => 
                new FuncDependencyResolver(new Func<Type, IGraphType>(type => 
                    (IGraphType)serviceProvider.GetRequiredService(type))));
        }
    }
}
