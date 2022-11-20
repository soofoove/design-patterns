namespace lab1.Interfaces;

using System;
using lab1.Models;

public interface ITaskChangesLogger
{
    void LogTaskChanges(Task task, DateTime dateTime);
}
