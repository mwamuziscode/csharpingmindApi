using csharpingmindApi.Models; // IMPORTED
using Microsoft.EntityFrameworkCore;
using System.Linq;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AuthsContext>(options =>
{
    options.UseInMemoryDatabase("AuthsDatabase");
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


// ADDED
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<AuthsContext>();
    await db.Database.EnsureCreatedAsync();
}


app.MapGet("/users", async (AuthsContext _context) =>
{
    var user = await _context.Users.ToArrayAsync();
    return Results.Ok(user);

});

app.MapGet("/users/{id}", async (int id, AuthsContext _context) =>
{
    var user = await _context.Users.FindAsync(id);
    if (user == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(user);
});


app.MapGet("/groups", async (AuthsContext _context) =>
{
    var groups = await _context.Groups.ToArrayAsync();
    return Results.Ok(groups);
});


app.MapGet("/group/{id}", async (int id, AuthsContext _context) =>
{
    var group = await _context.Groups.FindAsync(id);
    if (group == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(group);
});



app.MapGet("/users/is/isActive", async (AuthsContext _context) =>
{
    var users = await _context.Users.Where(u => u.IsActive && u.Age >= 30).ToArrayAsync();
    return Results.Ok(users);
});







app.Run();
