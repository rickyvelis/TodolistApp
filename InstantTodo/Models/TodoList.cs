namespace InstantTodo.Models
{
    public class TodoList
    {
        public List<TodoItem> TodoItems { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }

        public string GetPassedTime()
        {
            return "3 days ago"; //Dummy code. Functionality to be implemented.
        }

        public string GetTasksPreview()
        {
            return "Apples, Bread..."; //Dummy code. Functionality to be implemented.
        }
    }
}
