using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10.Logging
{
	public enum LogType { Comment, Warnning, Error, Notice }

    public static class LogService
    {
		private static ILogger _logger = null;

		public static void SetLogger(ILogger logger)
		{
			_logger = logger;
		}

		public static void AddLog(LogType logType, string message)
		{
			if (_logger == null) return;
			_logger.AddLog(logType, message, DateTime.Now);
		}

		public static void ClearLogs()
		{
			if (_logger == null) return;
			_logger.ClearLogs();
		}

		public static int Count()
		{
			if (_logger == null) return -1;
			return _logger.Count();
		}
    }
}
