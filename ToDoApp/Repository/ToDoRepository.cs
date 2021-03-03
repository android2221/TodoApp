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

        public async Task<List<ToDo>> getAllTodos(){
            return await _context.Todos.ToListAsync();
        }
    }
}