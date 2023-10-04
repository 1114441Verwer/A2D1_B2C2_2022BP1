using Microsoft.AspNetCore.Mvc;
using ToDoListModel.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoListAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoListController : ControllerBase
    {
        // GET: api/<ToDoListController>
        [HttpGet]
        public IEnumerable<ToDoTask> Get()
        {
            return ToDoTask.ReadAll();
            //return new string[] { "value1", "value2" };
        }

        // GET api/<ToDoListController>/5
        [HttpGet("{id}")]
        public ToDoTask Get(int id)
        {
            return ToDoTask.Read(id);
            //return "value";
        }

        // POST api/<ToDoListController>
        [HttpPost]
        public void Post([FromBody] string description)
        {
            ToDoTask newTask = new ToDoTask(description);
            newTask.Create();
        }

        // PUT api/<ToDoListController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ToDoListController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
