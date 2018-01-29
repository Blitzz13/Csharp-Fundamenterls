using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.Enums;

namespace Logger.Entities.Appenders
{
	class FileAppender : IAppender
	{
		public FileAppender(ILayout layout)
		{
			Layout = layout;
		}

		public ILayout Layout { get; }

		public ReportLevel ReportLevel { get; set; }

		public LogFile File { get; set; }

		public void Append(string timeStamp, string reportLevel, string message)
		{
			string formattedMsg = Layout.FormatMessage(timeStamp, reportLevel, message);
			File.Write(formattedMsg);
		}
	}
}
