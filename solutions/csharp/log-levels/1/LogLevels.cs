static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Split(':')[1].Trim();
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        int start = logLine.IndexOf('[') + 1;
        int end = logLine.IndexOf(']');
        return logLine.Substring(start, end - start).ToLower();
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }
    
    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string error = LogLevel(logLine);
        return $"{message} ({error})";
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
