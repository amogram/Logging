using Microsoft.Extensions.Logging;

namespace Logging
{
    /// <summary>
    /// Extension methods to add log4net to Conifgure() Methods on ASP.NET Startup
    /// </summary>
    public static class Log4NetExtensions
    {
        public static ILoggerFactory AddLog4Net(this ILoggerFactory factory, string log4NetConfigFile)
        {
            factory.AddProvider(new Log4NetProvider(log4NetConfigFile));
            return factory;
        }

        public static ILoggerFactory AddLog4Net(this ILoggerFactory factory)
        {
            const string log4NetConfigFile = "log4net.config";
            factory.AddProvider(new Log4NetProvider(log4NetConfigFile));
            return factory;
        }
    }
}
