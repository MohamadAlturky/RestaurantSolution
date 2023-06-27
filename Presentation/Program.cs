using Serilog;
using Application;
using MediatR;
using Application.UnitOfWork;
using Persistance.UnitOfWork;
using API.Middlewares;
using Application.JWTProvider;
using Infrastructure.Services.Authentication;

public class Program
{
	//public void ConfigureServices(IServiceCollection services)
	//{
	//	services.AddDbContext<RestaurantDB>(options =>
	//		options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

	//	services.AddControllersWithViews();
	//}
	public static void Main (string[] args)
	{

		var builder = WebApplication.CreateBuilder(args);



		Log.Logger = new LoggerConfiguration().MinimumLevel.Warning()
			.WriteTo.Seq("http://localhost:5341")
			.CreateLogger();


		builder.Host.UseSerilog();


		// Add services to the container.
		builder.Services.AddMediatR(typeof(MediatREntryPoint).Assembly);
		builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

		builder.Services.AddControllers();

		builder.Services.AddEndpointsApiExplorer();
		builder.Services.AddSwaggerGen();
		//builder.Services.AddLogging();
		builder.Services.AddScoped<GlobalExceptionHandler>();
		builder.Services.AddScoped<IJWTProvider,JWTProvider>();

		var app = builder.Build();

		// Configure the HTTP request pipeline.
		if (app.Environment.IsDevelopment())
		{
			app.UseSwagger();
			app.UseSwaggerUI();
		}

		app.UseHttpsRedirection();

		app.UseAuthorization();

		app.UseMiddleware<GlobalExceptionHandler>();
		app.MapControllers();

		app.Run();
	}
}
