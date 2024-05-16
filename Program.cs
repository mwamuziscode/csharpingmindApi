
/*
using csharpingmindApi.Models; // IMPORTED
using Microsoft.EntityFrameworkCore;
using System.Linq;




namespace csharpingmindApi
{
    public static Program
    {
    public static void Main(string[] args){
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddControllers();
        builder.Services.AddSwaggerGen();
        builder.Services.AddEndpointsApiExplorer();

        // connect sql database
        builder.Services.AddDbContext<AuthsContext>(options => 
        {
            // UseSqlServer || https://tutorials.eu/how-to-create-a-database-in-asp-net-core/
            options.UseSqlServer("Server=(localdb)\\mssqlocaldb;Database=csharpingminddb;Trusted_Connection=True;"));
        })


        var app = builder.Build();
        
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        
        app.UseHttpsRedirection();
        app.UseAuthorization();
        app.MapControllers();
        app.UseRouting();
        app.Run();
}}}

*/

using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using csharpingmindApi.Models; // Make sure this namespace correctly references where your AuthsContext is defined.
using Pomelo.EntityFrameworkCore.MySql;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();  // Adds support for controllers.
builder.Services.AddSwaggerGen();   // Adds Swagger generation.
builder.Services.AddEndpointsApiExplorer();  // Adds API explorer which Swagger uses.

// Configure the database context
builder.Services.AddDbContext<AuthsContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("csharpingmindDatabase"),
        new MySqlServerVersion(new Version(8,0,32))));  // Ensure you specify the correct version of MySQL Server you're using.

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseHttpsRedirection();
app.UseRouting();
app.UseAuthorization();
app.MapControllers();

app.Run();
