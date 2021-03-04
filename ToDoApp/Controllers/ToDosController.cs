using ToDoApp.Entities;
using ToDoApp.Services;

namespace ToDoApp.Controllers
{
    public class ToDosController : BasicController<ToDo>
    {
        public ToDosController(IBasicService<ToDo> service) : base(service)
        {
        }
    }
}