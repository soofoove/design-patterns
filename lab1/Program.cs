namespace lab1;

using lab1.Interfaces;
using lab1.Models;
using lab1.Models.Enums;
using lab1.Services;

public static class Program
{
    public static void Main(string[] args)
    {
        NotificationSenderProvider senderProvider = new NotificationSenderProvider();
        ITaskChangesLogger taskChangesLogger = new FileTaskChangesLogger();

        ProjectService projectService = new ProjectService(taskChangesLogger, senderProvider);

        User user1 = new User
        {
            FirstName = "John",
            LastName = "Doe"
        };

        User user2 = new User
        {
            FirstName = "Michael",
            LastName = "Jackson"
        };

        Task task = new Task
        {
            Title = "Some task",
            Description = "Excellent task",
            AssignedUser = user1
        };

        Project project = new Project
        {
            Admin = user2,
            Title = "Test project",
            Description = "Excellent project",
            Tasks = new[] { task },
            Users = new[] { user1 }
        };

        projectService.CreateTask(project, user1, new Task());
        projectService.UpdateTask(task);
        projectService.AddUserToProject(
            project,
            new User
            {
                FirstName = "Verka",
                LastName = "Serduchka"
            },
            NotificationSenderTypes.Messenger);
    }
}

