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

        public Task<List<ToDo>> getAllToDos()
        {
            return _repo.getAllTodos();
        }
    }
}
