namespace Abstraction.Core.Logger
{
    public class FakeLogger : ILogger
    {
        public void LogError(string message) { }

        public void LogInfo(string message) { }

        public void LogWarning(string message) { }
    }
}
