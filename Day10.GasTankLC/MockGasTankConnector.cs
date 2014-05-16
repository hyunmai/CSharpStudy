using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10.GasTankLC
{
	public class MockGasTankConnector : IGasTankConnector
	{
		private ValveState _valve1 = ValveState.Closed;
		private ValveState _valve2 = ValveState.Full;
		private bool _connected = false;

		public MockGasTankConnector(bool connected, ValveState v1State, ValveState v2State)
		{
			_connected = connected;
			_valve1 = v1State;
			_valve2 = v2State;
		}

		public bool CheckConnection()
		{
			return _connected;
		}

		public ValveState GetValveState(int valveNum)
		{
			if (CheckConnection() == false) return ValveState.Unknown;

			switch(valveNum)
			{
				case 1:
					return _valve1;
				case 2:
					return _valve2;
				default:
					return ValveState.Unknown;
			}
		}

		public bool SetValveState(int valveNum, ValveState valveState)
		{
			switch (valveNum)
			{
				case 1:
					_valve1 = valveState;
					return true;
				case 2:
					_valve2 = valveState;
					return true;
				default:
					return false;
			}
		}
	}
}
