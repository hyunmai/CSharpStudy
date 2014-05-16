using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10.Logging
{
	internal class DebugLogItem
	{
		public LogType Type { get; set; }
		public string Message { get; set; }
		public DateTime TimeCreated { get; set; }

		public void PrintLog()
		{
			string msg = Type.ToString() + ", " + Message + " " + TimeCreated.ToShortTimeString();
	
			System.Diagnostics.Debug.WriteLine(msg);
		}
	}

	public class DebugLogger : ILogger
	{
		private List<DebugLogItem> Logs = new List<DebugLogItem>();
		public void AddLog(LogType logType, string message, DateTime time)
		{
			var log = new DebugLogItem { Type = logType, Message = message, TimeCreated = time };
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
