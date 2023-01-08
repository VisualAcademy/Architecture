namespace Application.Todos.Commands.CreateTodo;

public interface ICreateTodoCommand
{
    void Execute(CreateTodoModel model);
}
