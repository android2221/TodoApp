using System.Collections.Generic;
using System.Threading.Tasks;

namespace ToDoApp.Services
{
    public interface IToDoService
  {
    Task<List<ToDo>> getAllToDos();
  }
}
