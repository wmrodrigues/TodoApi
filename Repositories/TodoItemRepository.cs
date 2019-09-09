using TodoApi.Models;

namespace TodoApi.Repositories
{
    public class TodoItemRepository : Repository<TodoItem>
    {
        private readonly TodoContext _ctx;
        public TodoItemRepository(TodoContext context) : base(context)
        {
            _ctx = context;
        }
    }
}