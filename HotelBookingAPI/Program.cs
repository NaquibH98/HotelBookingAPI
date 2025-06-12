using HotelBookingApi.Data;
using HotelBookingApi.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register the in-memory DB
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("HotelDb"));

var app = builder.Build();

// Seed data
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    context.Rooms.AddRange(
        new Room { Id = 1, Name = "101", Type = "Single", IsAvailable = true },
        new Room { Id = 2, Name = "102", Type = "Double", IsAvailable = true },
        new Room { Id = 3, Name = "201", Type = "Suite", IsAvailable = true }
    );
    context.SaveChanges();
}

app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
