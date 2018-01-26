using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Entities.Layouts
{
	class XmlLayout : ILayout
	{
		public string FormatMessage(string timeStamp, string reportLevel, string message)
		{
			StringBuilder msg = new StringBuilder();

			return msg.AppendLine("<log>")
				.AppendLine($"   <date>{timeStamp}</date>")
				.AppendLine($"   <level>{reportLevel}</level>")
				.AppendLine($"   <message>{message}</message>")
				.Append("</log>")
				.ToString();
		}
	}
}
