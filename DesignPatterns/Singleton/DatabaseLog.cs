using System;

namespace DesignPatterns.Singleton
{
    public sealed class DatabaseLog : ILog
    {
        public void LogException(Exception ex) { }
    }
}