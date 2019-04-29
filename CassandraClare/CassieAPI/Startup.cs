using CassandraClare.Data.Schema.Livros;
using CassandraClare.Data.Schema.Series;
using CassandraClare.Repositorios.Livros;
using CassandraClare.Repositorios.Series;
using CassandraClareBooks.Schema;
using GraphQL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using GraphQL.Server;
using Microsoft.Extensions.DependencyInjection;
using GraphQL.Server.Ui.GraphiQL;
using GraphQL.Server.Ui.Playground;
using GraphQL.Server.Ui.Voyager;

namespace Server
{
    public class Startup
    {
        public Startup(IHostingEnvironment environment)
        {
            Environment = environment;
        }
        public IHostingEnvironment Environment { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // serviços
            services.AddSingleton<ISeriesRepositorio, SeriesRepositorio>();
            services.AddSingleton<ILivrosRepositorio, LivrosRepositorio>();

            // objetos
            services.AddSingleton<SerieType>();
            services.AddSingleton<LivroType>();

            // query e schema
            services.AddSingleton<CassieQuery>();
            services.AddSingleton<CassieSchema>();

            services.AddSingleton<IDependencyResolver>(
                x => new FuncDependencyResolver(
                    type => x.GetRequiredService(type)
                )
            );

            services.AddGraphQL(options =>
            {
                options.EnableMetrics = true;
                options.ExposeExceptions = Environment.IsDevelopment();
            })
            .AddWebSockets()
            .AddDataLoader();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (Environment.IsDevelopment())
                app.UseDeveloperExceptionPage();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseWebSockets();
            app.UseGraphQLWebSockets<CassieSchema>("/graphql");
            app.UseGraphQL<CassieSchema>("/graphql");
            app.UseGraphQLPlayground(new GraphQLPlaygroundOptions()
            {
                Path = "/ui/playground"
            });
            app.UseGraphiQLServer(new GraphiQLOptions
            {
                GraphiQLPath = "/ui/graphiql",
                GraphQLEndPoint = "/graphql"
            });
            app.UseGraphQLVoyager(new GraphQLVoyagerOptions()
            {
                GraphQLEndPoint = "/graphql",
                Path = "/ui/voyager"
            });
        }
    }
}
