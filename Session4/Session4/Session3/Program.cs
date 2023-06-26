using MediatR;
using Microsoft.EntityFrameworkCore;
using Session3.Data;
using Session3.Services;
using System.Reflection;

namespace Session3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //  builder.Services.AddMediatR(Assembly.GetExecutingAssembly());

            //  builder.Services.AddDbContext<DataContext>(options =>
            //  options.UseSqlServer(builder.Configuration.GetConnectionString("path")));


            builder.Services.AddMediatR(typeof(Program));
            string dataConnection = builder.Configuration.GetConnectionString("path");
            builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer(dataConnection));


            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();

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