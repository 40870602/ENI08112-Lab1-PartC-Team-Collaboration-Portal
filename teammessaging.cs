// TeamMessaging.cs
// Handles sending messages within the team channel.
using System;

public class TeamMessaging
{
    public string Sender { get; set; }
    public string Message { get; set; }
    public DateTime Timestamp { get; set; }

    public bool SendMessage(string sender, string message)
    {
        if (string.IsNullOrWhiteSpace(message))
            return false; // empty messages cannot be sent

        Sender = sender;
        Message = message;
        Timestamp = DateTime.Now;
        return true;
    }
}