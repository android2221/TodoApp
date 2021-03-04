using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoApp.Entities;

namespace ToDoApp.Services
{
    public interface IToDoService
    {
        Task<List<ToDo>> GetAllToDos();
        Task<ToDo> GetToDo(int id);
        Task<int> AddToDo(ToDo todo);
        Task<ToDo> EditToDo(ToDo todo);
        Task DeleteToDo(int id);
    }
}
