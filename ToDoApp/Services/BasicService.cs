using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoApp.Entities;
using ToDoApp.Repository;

namespace ToDoApp.Services
{
    public class BasicService<T> : IBasicService<T>
    {
        private IBasicRepository<T> _repo;

        public BasicService(IBasicRepository<T> repository)
        {
            _repo = repository;
        }

        public Task<int> AddItem(T todo)
        {
            return _repo.AddItem(todo);
        }

        public async Task DeleteItem(int id)
        {
            await _repo.DeleteItem(id);
        }

        public async Task<T> EditItem(T item)
        {
            return await _repo.EditItem(item);
        }

        public Task<List<T>> GetAllItems()
        {
            return _repo.GetAllItems();
        }

        public Task<T> GetItem(int id)
        {
            return _repo.GetItem(id);
        }
    }
}
