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

        public Task DeleteToDo()
        {
            throw new NotImplementedException();
        }

        public Task<ToDo> EditToDo()
        {
            throw new NotImplementedException();
        }

        public Task<List<ToDo>> GetAllToDos()
        {
            return _repo.GetAllTodos();
        }

        public Task<ToDo> GetToDo()
        {
            throw new NotImplementedException();
        }
    }
}
