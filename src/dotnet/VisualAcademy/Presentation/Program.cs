using Application.Common.Interfaces;
using Application.Todos.Queries.GetTodos;
using Microsoft.EntityFrameworkCore;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DatabaseService>(opt => opt.UseInMemoryDatabase("TodoDb"));

builder.Services.AddTransient<IDatabaseService, DatabaseService>();

builder.Services.AddTransient<IGetTodosQuery, GetTodosQuery>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

//[1] DbContext 클래스 사용
app.MapGet("/api/todos/withdbcontext", (DatabaseService db) => db.Todos.ToList());

//[2] Query 클래스 사용
app.MapGet("/api/todos/withquery", (IGetTodosQuery query) => query.Execute());

app.Run();
