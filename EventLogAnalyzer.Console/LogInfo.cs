namespace EventLogAnalyzer.Console {
  public class LogInfo {
    public string Name { get; private set; }
    public string Log { get; private set; }

    public static LogInfo Security { get { return new LogInfo { Name = "Microsoft-Windows-Security-Auditing", Log = "Security" }; } }
  }
}