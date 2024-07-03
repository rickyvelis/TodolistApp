namespace InstantTodo.Models
{
    public class TodoList
    {
        public int Id { get; set; }
        public List<TodoItem> TodoItems { get; set; } = new();
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime Updated { get; set; } = DateTime.Now;

        private const int DESC_PREVIEW_MAX_LENGTH = 30;

        public string GetPassedTimeSinceUpdate()
        {
            TimeSpan passedTime = DateTime.Now.Subtract(Updated);

            switch (passedTime.TotalSeconds)
            {
                case > 604800:
                    return $"{passedTime.Days / 7} Week{(passedTime.Days / 7 == 1 ? "" : "s")} ago";
                case > 86400:
                    return $"{passedTime.Days} Day{(passedTime.Days == 1 ? "" : "s")} ago";
                case > 3600:
                    return $"{passedTime.Hours} Hour{(passedTime.Hours == 1 ? "" : "s")} ago";
                case > 60:
                    return $"{passedTime.Minutes} Minute{(passedTime.Minutes == 1 ? "" : "s")} ago";
                default:
                    return "<1 Minute ago";

            }
        }

        public string GetTasksPreview()
        {
            string preview = "";

            if (TodoItems.Count > 0)
            {

                int maxLength = 30;
                int i = 0;
                foreach (TodoItem item in TodoItems)
                {
                    if (i != 0) preview += ", ";
                    preview += item.Title;
                    if (i > 5) break;
                    i++;
                }
                if (preview.Length > 30) 
                { 
                    preview = preview[..maxLength] + "..."; 
                }

            }
            return preview;
        }

        public string GetDescriptionPreview()
        {
            if (string.IsNullOrEmpty(Description))
            {
                return "";
            }

            if (Description.Length > DESC_PREVIEW_MAX_LENGTH)
            {
                return Description[..DESC_PREVIEW_MAX_LENGTH] + "...";
            }
            else
            {
                return Description;
            }
        }
    }
}
