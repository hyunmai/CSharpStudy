using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10.Logging
{
	public interface ILogger
	{
		void AddLog(LogType logType, string message, DateTime time);

		void ClearLogs();

		int Count();
	}
}
