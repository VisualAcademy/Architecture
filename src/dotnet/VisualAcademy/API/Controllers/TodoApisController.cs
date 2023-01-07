using Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Persistence;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoApisController : ControllerBase
    {
        private readonly DatabaseService _db;

        public TodoApisController(DatabaseService db)
        {
            this._db = db;
        }

        // GET: api/<TodoApisController>
        [HttpGet]
        public List<Todo> Get()
        {
            return _db.Todos.ToList();
        }

        // POST api/<TodoApisController>
        [HttpPost]
        public void Post([FromBody] Todo todo)
        {
            _db.Todos.Add(todo);
            _db.SaveChanges();
        }
    }
}
