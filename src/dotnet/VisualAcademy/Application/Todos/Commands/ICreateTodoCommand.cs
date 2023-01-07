namespace Application.Todos.Commands;

public interface ICreateTodoCommand
{
    void Execute(CreateTodoModel model);
}
