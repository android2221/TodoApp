using ToDoApp.Entities;
using ToDoApp.Services;

namespace ToDoApp.Controllers
{
    public class EventsController : BasicController<Event>
    {
        public EventsController(IBasicService<Event> service) : base(service)
        {
        }
    }
}