namespace todo_api.Models;

public class TodoItem {
    public long id { get; set; }
    public string? Name { get; set; }
    public bool isComplete { get; set; }
}