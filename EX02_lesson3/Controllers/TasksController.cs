using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EX02_lesson3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        ITasksService taskService = new TasksService();

        // GET: api/<TasksController>
        [HttpGet]
        public List<Tasks> Get()
        {
            return taskService.GetTasks();
        }

        // GET api/<TasksController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<TasksController>
        [HttpPost]
        public ActionResult Post([FromBody] Tasks task)
        {

            bool res =  taskService.CreateTask(task);
            if (res)
                return Ok("task added successfully");
            return BadRequest("oops");

        }

   
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<TasksController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {

            bool res = taskService.DeleteTask(id);
            if (res)
                return Ok("task deleted successfully");
            return BadRequest("oops");
        }
    }
}
