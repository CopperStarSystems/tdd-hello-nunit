// HelloNunit.HelloNunit.BitBucketLogger.cs

namespace HelloNunit
{
    public class BitBucketLogger : LoggerBase
    {
        protected override void LogInternal(string message)
        {
            // Send the message to the bit bucket (i.e. discard it).
        }
    }
}