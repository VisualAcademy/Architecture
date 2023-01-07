namespace Application.Todos.Queries;

public interface IGetTodosQuery
{
    List<TodoModel> Execute();
}