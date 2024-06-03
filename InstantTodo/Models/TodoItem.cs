namespace InstantTodo.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public bool IsDone { get; set; } = false;
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set;} = DateTime.Now;

    }
}
