using Aplication.UseCases.AddCustomer;
using Domain.Contracts.Repositories.AddCustomer;
using Domain.Contracts.UseCases;
using Infra.Repository.Repositories.AddCustomer;

namespace ApiWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddSingleton<IAddCustomerRepository, AddCustomerRepository>();
            builder.Services.AddScoped<IAddCurstomerUseCase, AddCustomerUseCase>();

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

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