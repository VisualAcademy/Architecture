﻿using Application.Common.Interfaces;
using Domain.Entities;

namespace Application.Todos.Commands;

public class CreateTodoCommand : ICreateTodoCommand
{
    private readonly IDatabaseService _db;

    public CreateTodoCommand(IDatabaseService db) => this._db = db;

    public void Execute(CreateTodoModel model)
    {
        var todo = new Todo();
        todo.Name = model.Name;
        todo.IsComplete = model.IsComplete;

        _db.Todos.Add(todo);
        _db.Save();
    }
}
