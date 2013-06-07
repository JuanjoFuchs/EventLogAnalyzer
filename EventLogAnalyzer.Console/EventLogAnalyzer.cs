using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace EventLogAnalyzer.Console {
  public class EventLogAnalyzer {
    const string LOG = "System.Diagnostics.EventLog";

    EventLog _log;

    public EventLogAnalyzer() {
      _log = getLog(LogInfo.Security);
    }

    EventLog getLog(LogInfo info) {
      if (!EventLog.SourceExists(info.Name)) {
        throw new Exception(string.Format("Log '{0}' doest not exist", info.Name));
      } 

      return new EventLog { Source = LOG, Log = info.Log };
    }

    protected IEnumerable<Entry> Entries {
      get {
        return queryEventLog();
      }
    }

    protected IEnumerable<ConsolidatedEntry> ConsolidatedEntries {
      get {
        return consolidate(Entries);
      }
    }

    public IEnumerable<StatEntry> Stats {
      get {
        return getStats(ConsolidatedEntries);
      }
    }

    IEnumerable<Entry> queryEventLog() {
      yield break;
    }

    IEnumerable<ConsolidatedEntry> consolidate(IEnumerable<Entry> entries) {
      yield break;
    }

    IEnumerable<StatEntry> getStats(IEnumerable<ConsolidatedEntry> consolidatedEntries) {
      yield break;
    }
  }
}