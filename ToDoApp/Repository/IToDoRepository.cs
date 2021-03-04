using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoApp.Entities;

namespace ToDoApp.Repository
{
    public interface IToDoRepository
    {
        Task<List<ToDo>> GetAllTodos();
        Task<ToDo> GetToDo(int id);
        Task<int> AddToDo(ToDo todo);
        Task<ToDo> EditToDo(ToDo todo);
        Task DeleteToDo(int id);
    }
}