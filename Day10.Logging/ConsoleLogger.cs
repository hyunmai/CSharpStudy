using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10.Logging
{
	internal class LogItem
	{
		public LogType Type { get; set; }
		public string Message { get; set; }
		public DateTime TimeCreated { get; set; }

		public void PrintLog()
		{
			switch(Type)
			{
				case LogType.Comment:
					Console.ForegroundColor = ConsoleColor.Gray;
					break;
				case LogType.Error:
					Console.ForegroundColor = ConsoleColor.Red;
					break;
				case LogType.Notice:
					Console.ForegroundColor = ConsoleColor.Green;
					break;
				case LogType.Warnning:
					Console.ForegroundColor = ConsoleColor.Yellow;
					break;
			}

			string msg = Type.ToString() + ", " + Message + " " + TimeCreated.ToShortTimeString();
			Console.WriteLine(msg);

			Console.ResetColor();
		}
	}

	public class ConsoleLogger : ILogger
	{
		private List<LogItem> Logs = new List<LogItem>();
		public void AddLog(LogType logType, string message, DateTime time)
		{
			var log = new LogItem { Type = logType, Message = message, TimeCreated = time };
			Logs.Add(log);
			log.PrintLog();
		}

		public void ClearLogs()
		{
			Logs.Clear();
		}

		public int Count()
		{
			return Logs.Count;
		}
	}
}
