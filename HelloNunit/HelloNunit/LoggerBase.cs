// HelloNunit.HelloNunit.LoggerBase.cs

namespace HelloNunit
{
    public abstract class LoggerBase : ILogger
    {
        public void Log(string message)
        {
            LogInternal(message);
        }

        protected abstract void LogInternal(string message);
    }
}