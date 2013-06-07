using System.Collections.Generic;

namespace EventLogAnalyzer.Console {
  internal static class EventLogAnalyzerConsole {
    public static void Run(string[] args) {
      run(parse(args));
    }

    static void run(Options options) {
      var analyzer = new EventLogAnalyzer();
      runStats(analyzer);
    }

    static void runStats(EventLogAnalyzer analyzer) {
      var stats = analyzer.Stats;
      print(stats);
    }

    static void print(IEnumerable<StatEntry> stats) {
      
    }

    static Options parse(string[] args) {
      return default(Options);
    }

    sealed class Options {}
  }
}