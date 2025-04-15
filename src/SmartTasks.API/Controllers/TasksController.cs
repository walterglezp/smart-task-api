using Microsoft.AspNetCore.Mvc;
using SmartTasks.Domain.Entities;
using SmartTasks.Domain.Enums;
using SmartTasks.Domain.Resources;
using SmartTasks.Infrastructure;
using System.Text.Json;

namespace SmartTasks.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // <-- maps to 'api/tasks'
    public class TasksController : ControllerBase
    {
        private readonly AppDbContext _db;

        public TasksController(AppDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public IActionResult GetAllTasks()
        {
            var tasks = _db.Tasks.ToList();
            return Ok(tasks);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTask([FromBody] TaskResource task)
        {
            var now = DateTime.UtcNow;

            var record = new TaskRecord
            {
                Id = Guid.NewGuid(),
                Version = 1,
                Cts = now,
                Ts = now,
                Status = RecordStatus.Created,
                ResourceType = "Task",
                Resource = JsonSerializer.Serialize(task)
            };

            _db.Tasks.Add(record);
            await _db.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTask), new { id = record.Id }, record);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTask(Guid id)
        {
            var task = await _db.Tasks.FindAsync(id);

            if (task == null)
                return NotFound();

            return Ok(task);
        }
    }
}
