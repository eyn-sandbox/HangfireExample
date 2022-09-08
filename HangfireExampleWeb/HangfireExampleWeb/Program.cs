using Hangfire;
using Hangfire.PostgreSql;

namespace HangfireExampleWeb
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

            builder.Services.AddHangfire(config =>
                config.UsePostgreSqlStorage("Host=192.168.88.47;Database=postgres;Username=testuser;Password=testpass"));

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.UseHangfireServer();
            app.UseHangfireDashboard();
            
            app.MapControllers();

            app.Run();
        }
    }
}
