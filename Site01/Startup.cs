using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Site01.Database;

namespace Site01
{
    public class Startup
	{
		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{

			// ADICIONAR MVC
			services.AddMvc();

			// CONFIGURAR A CONEXAO COM O BANCO DE DADOS
			services.AddDbContext<DatabaseContext>(options=>
			{
				// providers - blibliotecas que servem para o EF fazer conexao com o banco de dados
				options.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=site01;Integrated Security = False;");
			});

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}

			// MÉTODO PARA ACESSAR ITENS ESTÉTICOS
			app.UseStaticFiles();

			//CONFIGURAR O MVC
			app.UseMvcWithDefaultRoute();
		}
	}
}
