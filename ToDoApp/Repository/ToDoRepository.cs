using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoApp.Entities;
using Microsoft.EntityFrameworkCore;
using ToDoApp.Mappers;

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
            await _context.SaveChangesAsync();
            return todo.ID;
        }

        public async Task DeleteToDo(int id)
        {
            await _context.Todos.FirstAsync<ToDo>(x => x.ID == id);
        }

        public async Task<ToDo> EditToDo(ToDo inboundTodo)
        {
            var editItem = await _context.Todos.FirstAsync<ToDo>(x => x.ID == inboundTodo.ID);
            var editedObject = ToDoMapper.MapChanges(inboundTodo, editItem);
            await _context.SaveChangesAsync();
            return editedObject;
        }

        public async Task<List<ToDo>> GetAllTodos(){
            return await _context.Todos.ToListAsync();
        }

        public async Task<ToDo> GetToDo(int id)
        {
            return await _context.Todos.FirstAsync<ToDo>(x => x.ID == id);
        }
    }
}