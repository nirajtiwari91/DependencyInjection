using DependencyInjectionExample;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<IUserService, UserService>(); // For the old version
//builder.Services.AddScoped<IUserService, UserServiceNew>(); // For the new version
//builder.Services.AddTransient<IUserService, UserServiceNew>(); // Transient
//builder.Services.AddSingleton<IUserService, UserServiceNew>(); // Singleton

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
