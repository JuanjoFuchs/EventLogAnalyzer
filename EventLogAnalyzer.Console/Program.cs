using System;
using System.Reflection;

namespace EventLogAnalyzer.Console {
  internal class Program {
    static void Main(string[] args) {
      registerEmbeddedResources();
      EventLogAnalyzerConsole.Run(args);
    }

    static void registerEmbeddedResources() {
      AppDomain.CurrentDomain.AssemblyResolve += currentDomainOnAssemblyResolve;
    }

    static Assembly currentDomainOnAssemblyResolve(object sender, ResolveEventArgs args) {
      using (var manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("EventLogAnalyzer.Console.CommandLine.dll")) {
        if (manifestResourceStream == null) {
          throw new Exception("Can't parse command line");
        }

        var buffer = new byte[manifestResourceStream.Length];
        manifestResourceStream.Read(buffer, 0, buffer.Length);
        return Assembly.Load(buffer);
      }
    }
  }
}