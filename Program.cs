using csharpingmindApi.Models; // IMPORTED
using Microsoft.EntityFrameworkCore;


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


app.MapGet("/products", async (AuthsContext _context) =>
{
    return await _context.Users.ToArrayAsync();
});




app.Run();
