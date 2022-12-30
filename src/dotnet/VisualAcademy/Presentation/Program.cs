using Microsoft.EntityFrameworkCore;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseService>(opt => opt.UseInMemoryDatabase("TodoDb"));

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//[1] DbContext Ŭ���� ���
app.MapGet("/api/todos/withdbcontext", (DatabaseService db) => db.Todos.ToList());

app.Run();
