namespace BlazorToDo;

public class ToDoItem
{
    public string? Title { get; set; }
    public bool Completed { get; set; } = false;

    public ToDoItem(string title)
    {
        Title = title;
        Completed = false;
    }
}