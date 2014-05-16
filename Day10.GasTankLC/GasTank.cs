using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Day10.Logging;

namespace Day10.GasTankLC
{
	public enum ValveState { Unknown, Full, Half, Closed }

	public interface IGasTankConnector
	{
		bool CheckConnection();
		ValveState GetValveState(int valveNum);
		bool SetValveState(int valveNum, ValveState valveState);
	}

	/// <summary>
	/// loose coupling Example
	/// C# Study Day10
	/// </summary>
	public class GasTank
	{
		private IGasTankConnector _connector;

		public GasTank(string name, IGasTankConnector connector)
		{
			_connector = connector;
		}

		public string Name { get; set; }

		public bool CheckConnection()
		{
			LogService.AddLog(LogType.Notice, "CheckConnection");
			return _connector.CheckConnection();
		}

		public ValveState GetValveState(int valveNum)
		{
			return _connector.GetValveState(valveNum);
		}

		public bool SetValveState(int valveNum, ValveState valveState)
		{
			return _connector.SetValveState(valveNum, valveState);
		}
	}
}
