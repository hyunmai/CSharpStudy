using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10.GasTankLC
{
	public class SerialGasTankConnector : IGasTankConnector
	{
		public bool CheckConnection()
		{
			throw new NotImplementedException();
		}

		public ValveState GetValveState(int valveNum)
		{
			throw new NotImplementedException();
		}

		public bool SetValveState(int valveNum, ValveState valveState)
		{
			throw new NotImplementedException();
		}
	}
}
