using Microsoft.AspNetCore.Http.Json;
using System.Text.Json.Serialization;
using BangazonBackend.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// allows passing datetimes without time zone data 
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

// allows our api endpoints to access the database through Entity Framework Core
builder.Services.AddNpgsql<BangazonBackendDbContext>(builder.Configuration["BangazonBackendDbConnectionString"]);

// Set the JSON serializer options
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}




// GET USERS 

app.MapGet("/api/users", (BangazonBackendDbContext db) =>
{
    return db.Users.ToList();
});


// GET USERS BY ID

app.MapGet("/api/users/{id}", (BangazonBackendDbContext db, int id) =>
{
    User user = db.Users.SingleOrDefault(u => u.Id == id);
    if (user == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(user);
});


// POST USERS

app.MapPost("/api/users", (BangazonBackendDbContext db, User user) =>
{
    db.Users.Add(user);
    db.SaveChanges();
    return Results.Created($"/api/users/{user.Id}", user);
});


// UPDATE USERS

app.MapPut("/api/users/{id}", (BangazonBackendDbContext db, int id, User user) =>
{
    User updateUser = db.Users.SingleOrDefault(u => u.Id == id);
    if (updateUser == null)
    {
        return Results.NotFound();
    }
    updateUser.FirstName = user.FirstName;
    updateUser.LastName = user.LastName;
    updateUser.Email = user.Email;
    updateUser.Address = user.Address;
    updateUser.IsSeller = user.IsSeller;
    db.SaveChanges();
    return Results.Ok(updateUser);
});


// DELETE USERS

app.MapDelete("/api/users/{id}", (BangazonBackendDbContext db, int id) =>
{
    User deleteUser = db.Users.SingleOrDefault(u => u.Id == id);
    if (deleteUser == null)
    {
        return Results.NotFound();
    }
    db.Users.Remove(deleteUser);
    db.SaveChanges();
    return Results.Ok(deleteUser);
});


app.UseHttpsRedirection();

app.Run();

