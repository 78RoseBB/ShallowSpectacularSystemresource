using System;
using System.IO;

public class Logger
{
    public static void LogMessage(string logFile, string message, string level)
    {
        string timestamp = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        string logEntry = $"[{timestamp}] [{level}] {message}\n";

        try
        {
            using (StreamWriter writer = new StreamWriter(logFile, true))
            {
                writer.Write(logEntry);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error writing to log file: {ex.Message}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Logger.LogMessage("application.log", "User logged in", "INFO");
        Logger.LogMessage("application.log", "Failed login attempt", "WARNING");
    }
}
