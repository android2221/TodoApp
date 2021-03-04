using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoApp.Entities;

namespace ToDoApp.Services
{
    public interface IBasicService<T>
    {
        Task<List<T>> GetAllItems();
        Task<T> GetItem(int id);
        Task<int> AddItem(T todo);
        Task<T> EditItem(T todo);
        Task DeleteItem(int id);
    }
}
