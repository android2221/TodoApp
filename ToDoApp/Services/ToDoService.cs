using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoApp.Entities;
using ToDoApp.Repository;

namespace ToDoApp.Services
{
    public class ToDoService : IToDoService
    {
        private IToDoRepository _repo;

        public ToDoService(IToDoRepository repository)
        {
            _repo = repository;
        }

        public Task<int> AddToDo(ToDo todo)
        {
            return _repo.AddToDo(todo);
        }

        public async Task DeleteToDo(int id)
        {
            await _repo.DeleteToDo(id);
        }

        public async Task<ToDo> EditToDo(ToDo todo)
        {
            return await _repo.EditToDo(todo);
        }

        public Task<List<ToDo>> GetAllToDos()
        {
            return _repo.GetAllTodos();
        }

        public Task<ToDo> GetToDo(int id)
        {
            return _repo.GetToDo(id);
        }
    }
}
