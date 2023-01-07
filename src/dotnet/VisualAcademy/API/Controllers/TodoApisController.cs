using Application.Common.Interfaces;
using Application.Todos.Commands;
using Application.Todos.Queries;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoApisController : ControllerBase
    {
        private readonly IDatabaseService _db;
        private readonly ICreateTodoCommand _cmd;
        private readonly IGetTodosQuery _query;

        public TodoApisController(IDatabaseService db, ICreateTodoCommand cmd, IGetTodosQuery query)
        {
            this._db = db;
            this._cmd = cmd;
            this._query = query;
        }

        // GET: api/<TodoApisController>
        [HttpGet]
        public List<TodoModel> Get()
        {
            //return _db.Todos.ToList();
            return _query.Execute(); 
        }

        // POST api/<TodoApisController>
        [HttpPost]
        public void Post([FromBody] CreateTodoModel todo)
        {
            //_db.Todos.Add(todo);
            //_db.Save();
            _cmd.Execute(todo); 
        }
    }
}
