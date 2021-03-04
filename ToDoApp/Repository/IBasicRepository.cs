using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoApp.Entities;

namespace ToDoApp.Repository
{
    public interface IBasicRepository<T>
    {
        Task<List<T>> GetAllItems();
        Task<T> GetItem(int id);
        Task<int> AddItem(T item);
        Task<T> EditItem(T item);
        Task DeleteItem(int id);
    }
}