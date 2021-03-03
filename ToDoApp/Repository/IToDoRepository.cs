using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoApp.Entities;

namespace ToDoApp.Repository
{
    public interface IToDoRepository
    {
         Task<List<ToDo>> getAllTodos();
    }
}