namespace lab1.Models;

public class Task
{
    public string Title { get; set; }
    public string Description { get; set; }
    public User AssignedUser { get; set; }
}
