using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoApp.Entities;
using Microsoft.EntityFrameworkCore;

namespace ToDoApp.Repository
{
    public class ToDoRepository : IToDoRepository
    {
        private readonly DbContexts _context;

        public ToDoRepository(DbContexts context)
        {
            _context = context;
        }

        public async Task<int> AddToDo(ToDo todo)
        {
            await _context.Todos.AddAsync(todo);
            var id = await _context.SaveChangesAsync();
            return id;
        }

        public Task DeleteToDo()
        {
            throw new System.NotImplementedException();
        }

        public Task<ToDo> EditToDo()
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<ToDo>> GetAllTodos(){
            return await _context.Todos.ToListAsync();
        }

        public Task<ToDo> GetToDo()
        {
            throw new System.NotImplementedException();
        }
    }
}