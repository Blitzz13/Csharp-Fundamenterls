using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Entities
{
	class LogFile
	{
		private const string DefaultFileName = "log.txt";
		private StringBuilder stringBuilder;

		public LogFile()
		{
			stringBuilder = new StringBuilder();
		}

		public int Size { get; private set; }

		private int GetLettersOnlySum(string message)
		{
			return message.Where(char.IsLetter).Sum(c => c);
		}

		public void Write(string message)
		{
			this.stringBuilder.AppendLine(message);
			File.AppendAllText(DefaultFileName,message + Environment.NewLine);
			this.Size = GetLettersOnlySum(message);
		}
	}
}
