using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoApp.Entities;

namespace ToDoApp.Repository
{
    public interface IToDoRepository
    {
        Task<List<ToDo>> GetAllTodos();
        Task<ToDo> GetToDo();
        Task<int> AddToDo(ToDo todo);
        Task<ToDo> EditToDo();
        Task DeleteToDo();
    }
}