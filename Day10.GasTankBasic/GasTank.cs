using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10.GasTankBasic
{
	public enum ValveState { Full, Half, Closed }

	/// <summary>
	///  tight coupling Example
	/// C# Study Day10
	/// </summary>
	public class GasTank
	{
		private string _connectionString;

		public GasTank(string name, string connectionString)
		{
			Name = name;
			_connectionString = connectionString;
		}

		public string Name { get; set; }

		public bool CheckConnection()
		{
			// connection code
			// ...
			// ...
			return true;
		}

		public ValveState GetValveState(int valveNum)
		{
			// connection code
			// ...
			// ...
			return ValveState.Full;
		}

		public bool SetValveState(int valveNum)
		{
			// connection code
			// ...
			// ...
			return true;
		}
	}
}
