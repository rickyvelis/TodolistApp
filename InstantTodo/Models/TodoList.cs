namespace InstantTodo.Models
{
    public class TodoList
    {
        public List<TodoItem> TodoItems { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
