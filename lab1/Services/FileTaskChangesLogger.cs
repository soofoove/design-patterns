namespace lab1.Services;

using System;
using lab1.Interfaces;
using lab1.Models;

public class FileTaskChangesLogger : ITaskChangesLogger
{
    public void LogTaskChanges(Task task, DateTime dateTime)
    {
        Console.WriteLine($"Logs task changes made by user {task.AssignedUser.FirstName}");
    }
}
