// TaskDeadlines.cs
// Handles task due dates and reminders.
using System;

public class TaskDeadlines
{
    public DateTime DueDate { get; set; }

    public bool IsOverdue()
    {
        return DateTime.Now > DueDate;
    }

    public bool IsDueSoon()
    {
        return (DueDate - DateTime.Now).TotalHours <= 24 && !IsOverdue();
    }
}