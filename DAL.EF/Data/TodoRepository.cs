using DAL.EF.Interface.DA;
using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.EF.Data
{
    public class TodoRepository : ITodoRepository
    {
        private TodoContext _context;

        public TodoRepository(TodoContext context)
        {
            _context = context;
        }

        public int AddItem(TodoItem item)
        {
            _context.TodoItem.Add(item);
            return _context.SaveChanges();
        }

        public TodoItem GetItem(long Id) => _context.TodoItem.FirstOrDefault(i => i.Id == Id);

        public IEnumerable<TodoItem> GetTodoList() => _context.TodoItem.ToList();
    }
}
