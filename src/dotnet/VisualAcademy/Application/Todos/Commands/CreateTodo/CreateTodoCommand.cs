using Application.Common.Interfaces;
using Domain.Entities;

namespace Application.Todos.Commands.CreateTodo;

public class CreateTodoCommand : ICreateTodoCommand
{
    private readonly IDatabaseService _db;

    public CreateTodoCommand(IDatabaseService db) => _db = db;

    public void Execute(CreateTodoModel model)
    {
        var todo = new Todo
        {
            Name = model.Name,
            IsComplete = model.IsComplete
        };

        _db.Todos.Add(todo);
        _db.Save();
    }
}
