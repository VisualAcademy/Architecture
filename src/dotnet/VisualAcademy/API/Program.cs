using Application.Common.Interfaces;
using Application.Todos.Commands.CreateTodo;
using Application.Todos.Queries.GetTodos;
using Microsoft.EntityFrameworkCore;
using Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<DatabaseService>(opt => opt.UseInMemoryDatabase("TodoDb"));

builder.Services.AddTransient<IDatabaseService, DatabaseService>();
builder.Services.AddTransient<ICreateTodoCommand, CreateTodoCommand>();
builder.Services.AddTransient<IGetTodosQuery, GetTodosQuery>();

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
