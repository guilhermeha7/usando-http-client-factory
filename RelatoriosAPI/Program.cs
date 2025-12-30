
using RelatoriosAPI.Services;

namespace RelatoriosAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<PessoasService>(); //Permite ao framework criar uma instância de PessoasService automaticamente quando um controller for gerado
            //Quero poder fazer requisições para a API em localhost:7154
            builder.Services.AddHttpClient("PessoasAPI", client =>
            {
                client.BaseAddress = new Uri("https://localhost:7154/");
            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
