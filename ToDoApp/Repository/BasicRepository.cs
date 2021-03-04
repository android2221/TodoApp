using System.Collections.Generic;
using System.Threading.Tasks;
using ToDoApp.Entities;
using Microsoft.EntityFrameworkCore;
using ToDoApp.Mappers;

namespace ToDoApp.Repository
{
    public class BasicRepository<T> : IBasicRepository<T> where T : class, IBasicItem
    {
        private readonly DbContexts _context;
        private readonly DbSet<T> _entities;

        public BasicRepository(DbContexts context)
        {
            _context = context;
            _entities = context.Set<T>();
        }

        public async Task<int> AddItem(T item)
        {
            await _entities.AddAsync(item);
            await _context.SaveChangesAsync();
            return item.ID;
        }

        public async Task DeleteItem(int id)
        {
            var item = await _entities.FirstOrDefaultAsync<T>(x => x.ID == id);
            _entities.Remove(item);
            await _context.SaveChangesAsync();
        }

        public async Task<T> EditItem(T inboundItem)
        {
            var editItem = await _entities.FirstOrDefaultAsync<T>(x => x.ID == inboundItem.ID);
            var editedObject = ToDoMapper<T>.MapChanges(inboundItem, editItem);
            await _context.SaveChangesAsync();
            return editedObject;
        }

        public async Task<List<T>> GetAllItems(){
            return await _entities.ToListAsync();
        }

        public async Task<T> GetItem(int id)
        {
            return await _entities.FirstOrDefaultAsync<T>(x => x.ID == id);
        }
    }
}