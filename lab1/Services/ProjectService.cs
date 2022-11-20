namespace lab1.Services;

using System;
using lab1.Interfaces;
using lab1.Models;
using lab1.Models.Enums;

public class ProjectService
{
    private readonly NotificationSenderProvider _notificationSenderProvider;
    private readonly ITaskChangesLogger _taskChangesLogger;

    public ProjectService(ITaskChangesLogger taskChangesLogger, NotificationSenderProvider notificationSenderProvider)
    {
        _taskChangesLogger = taskChangesLogger;
        _notificationSenderProvider = notificationSenderProvider;
    }

    public void CreateTask(Project project, User user, Task task)
    {
        // adds task to project, assign it on user
        // send notification
        _notificationSenderProvider.DefaultSender.SendNotification(user, new Notification{ Message = "Task was assigned to user" });
    }

    public void UpdateTask(Task task)
    {
        // update task status
        // log changes
        _taskChangesLogger.LogTaskChanges(task, DateTime.UtcNow);
    }

    public void AddUserToProject(Project project, User newUser, NotificationSenderTypes? senderType = null)
    {
        // add new user to project
        // send notification to admin

        Notification notification = new Notification { Message = "New user was added" };

        if (senderType != null)
        {
            _notificationSenderProvider.GetSender(senderType.Value).SendNotification(project.Admin, notification);
        }
        else
        {
            _notificationSenderProvider.DefaultSender.SendNotification(project.Admin, notification);
        }
    }
}
