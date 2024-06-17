using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Restaurant.DataAccess;
using Restaurant.Repositories.Implementaciones;
using Restaurant.Repositories.Implemntaciones;
using Restaurant.Repositories.Interfaces;
using Restaurant.Server.Services;
using Restaurant.Services.Implementaciones;
using Restaurant.Services.Interfaces;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
const string corConfiguration = "Blazor";

// Add services to the container.
builder.Services.AddDbContext<RestaurantDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("RestaurantDBConnection"));
});

builder.Services.AddCors(policy =>
{
    policy.AddPolicy(corConfiguration, config =>
    {
        config.AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

// Configuramos ASP.NET Identity Core
builder.Services.AddIdentity<IdentityUserRestaurant, IdentityRole>(policies =>
{
    policies.Password.RequireDigit = false;
    policies.Password.RequireLowercase = true;
    policies.Password.RequireUppercase = true;
    policies.Password.RequireNonAlphanumeric = false;
    policies.Password.RequiredLength = 8;

    policies.User.RequireUniqueEmail = true;
})
    .AddEntityFrameworkStores<RestaurantDbContext>()
    .AddDefaultTokenProviders();

// Configuramos el contexto de seguridad del API
builder.Services.AddAuthentication(x =>
{
    x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(x =>
{
    var secretKey = Encoding.UTF8.GetBytes(builder.Configuration["Jwt:SecretKey"] ??
                                           throw new InvalidOperationException("No se configuro el SecretKey"));

    x.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(secretKey)
    };
});

builder.Services.AddControllers();
builder.Services.AddTransient<ICategoriaRepository, CategoriaRepository>();
builder.Services.AddTransient<IClienteRepository, ClienteRepository>();
builder.Services.AddTransient<IProductoRepository, ProductoRepository>();
builder.Services.AddTransient<IMeseroRepository, MeseroRepository>();
builder.Services.AddTransient<IUserService, UserService>();

if (builder.Environment.IsDevelopment())
    builder.Services.AddTransient<IFileUploader, FileUploader>();
else
    builder.Services.AddTransient<IFileUploader, AzureFileUploader>();

//Swagger/OpenAPI
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

app.UseAuthentication();

app.UseAuthorization();

app.UseStaticFiles();

app.UseCors(corConfiguration);

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    await UserDataSeeder.Seed(scope.ServiceProvider);
}

app.Run();
