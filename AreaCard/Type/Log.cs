using NLog;

namespace AreaCard.Type
{
    public class Log
    {
        public static Logger Logger { get; } = LogManager.GetCurrentClassLogger();
    }
}
