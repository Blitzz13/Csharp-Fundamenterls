using Logger.Entities;
using Logger.Entities.Appenders;
using Logger.Entities.Layouts;
using Logger.Enums;

namespace Logger
{
	class Program
	{
		static void Main(string[] args)
		{
			var simpleLayout = new SimpleLayout();
			var consoleAppender = new ConsoleAppender(simpleLayout);
			consoleAppender.ReportLevel = ReportLevel.Error;

			var logger = new Entities.Logger(consoleAppender);

			logger.Info("3/31/2015 5:33:07 PM", "Everything seems fine");
			logger.Warn("3/31/2015 5:33:07 PM", "Warning: ping is too high - disconnect imminent");
			logger.Error("3/31/2015 5:33:07 PM", "Error parsing request");
			logger.Critical("3/31/2015 5:33:07 PM", "No connection string found in App.config");
			logger.Fatal("3/31/2015 5:33:07 PM", "mscorlib.dll does not respond");


		}
	}
}
