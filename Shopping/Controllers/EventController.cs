using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shopping.Application;
using Shopping.Models;

namespace Shopping.Controllers
{
    public class EventController : Controller
    {
        private EventApplication _application;
        public EventController(EventApplication application) 
        { 
            _application = application;
        }

        [HttpPost]
        public async Task<ActionResult<Event>> PostEvent(Event @event)
        {
            return CreatedAtAction(nameof(GetEvent), new { id = @event.Id }, _application.Create(@event));
        }

        [HttpGet("{id}")]
        public async Task<Event> GetEvent(int id)
        {
            return _application.Get(id);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
        {
            return _application.GetEvents();
        }

        [HttpPut]
        public async Task<IActionResult> PutEvent(Event @event)
        {
            _application.Update(@event);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            _application.Delete(id);
            return Ok();
        }

      
    }
}
