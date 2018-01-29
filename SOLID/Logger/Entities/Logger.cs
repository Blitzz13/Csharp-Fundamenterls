using System;
using Logger.Enums;

namespace Logger.Entities
{
	class Logger : ILogger
	{
		private IAppender[] _appenders;

		public Logger(params IAppender[] appenders)
		{
			_appenders = appenders;
		}

		private void Log(string timeStamp, string reportLevel, string message)
		{
			ReportLevel currentReportLevel = (ReportLevel)Enum.Parse(typeof(ReportLevel), reportLevel);
			foreach (var appender in _appenders)
			{
				if (appender.ReportLevel <= currentReportLevel)
				{
					appender.Append(timeStamp, reportLevel, message);
				}

			}
		}

		public void Error(string timeStamp, string message)
		{
			Log(timeStamp, "Error", message);
		}

		public void Info(string timeStamp, string message)
		{
			Log(timeStamp, "Info", message);
		}

		public void Fatal(string timeStamp, string message)
		{
			Log(timeStamp, "Fatal", message);
		}

		public void Critical(string timeStamp, string message)
		{
			Log(timeStamp, "Critical", message);
		}

		public void Warn(string timeStamp, string message)
		{
			Log(timeStamp, "Warning", message);
		}
	}
}
