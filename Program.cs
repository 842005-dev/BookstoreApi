using Microsoft.EntityFrameworkCore;
using BookstoreApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Add DbContext
builder.Services.AddDbContext<BookstoreContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// Add Controllers
builder.Services.AddControllers();

// Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Use Swagger
app.UseSwagger();
app.UseSwaggerUI();

// No HTTPS redirection — HTTP only
// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run("http://localhost:7000"); // force HTTP
