
using DS.Foundation.Configuration.Options;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.EntityFrameworkCore;
using Monitoreo.WebApi.Data;

namespace Monitoreo.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Configuration.AddJsonFile("appsettings.json");

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var configuration = builder.Configuration;
            var dap = configuration.GetSection("Database").Get<DatabaseAccessPointOptions>();
            if(dap == null) throw new Exception("Database configuration is missing.");

            builder.Services.AddDbContext<DataContext>(optionsBuilder =>
            {
                optionsBuilder.UseMySql(dap.ConnectionString, new MySqlServerVersion(dap.Version));
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
