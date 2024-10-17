using TwTodoLis.Models;

namespace TwTodoLis.ViewModel
{
    public class ListTodoViewModel
    {
        public ICollection<Todo> Todos { get; set; } = new List<Todo>();
    }
}
