using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoApp.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoApp.Controllers
{
    [Route("api/[controller]")]
    public class BasicController<T> : ControllerBase
    {
        private readonly IBasicService<T> _service;

        public BasicController(IBasicService<T> service)
        {
            _service = service;
        }

        // GET: api/values
        [HttpGet]
        public async Task<List<T>> Get()
        {
            return await _service.GetAllItems();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public async Task<T> Get(int id)
        {
          return await _service.GetItem(id);
        }  

        // POST api/values
        [HttpPost]
        public async Task<int> Post([FromBody] T value)
        {
          return await _service.AddItem(value);
        }

        // PUT api/values/
        [HttpPut]
        public async Task<T> Put([FromBody] T value)
        {
          return await _service.EditItem(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
          await _service.DeleteItem(id);
        }
    }
}
