using DAL.EF.Interface.DA;
using DAL.EF.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ToDoWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class TodoController : Controller
    {
        private readonly ITodoRepository _serviceRepo;

        public TodoController(ITodoRepository serviceRepo)
        {

            _serviceRepo = serviceRepo;
            if (_serviceRepo.GetTodoList().Count() == 0)
            {
                _serviceRepo.AddItem(new TodoItem { Name = "Item1" });
            }
        }

        //[HttpGet(Name ="GetAll")]
        public IEnumerable<TodoItem> Get()
        { 
            return _serviceRepo.GetTodoList();
        }

        [HttpGet("{id}", Name = "GetTodo")]
        public IActionResult GetById(long Id)
        {
            var item = _serviceRepo.GetItem(Id);
            if (item == null)
                return NotFound();
            return new OkObjectResult(item);
        }
    }
}
