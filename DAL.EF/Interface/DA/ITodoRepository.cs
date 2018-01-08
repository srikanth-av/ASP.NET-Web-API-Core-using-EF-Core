using DAL.EF.Models;
using System.Collections.Generic;

namespace DAL.EF.Interface.DA
{
    public interface ITodoRepository
    {
        int AddItem(TodoItem item);
        TodoItem GetItem(long Id);
        IEnumerable<TodoItem> GetTodoList();
    }
}
