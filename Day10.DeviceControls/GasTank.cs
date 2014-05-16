using Day10.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10.DeviceControls
{
	public enum ValveState { UnChecked, Error, Full, Half, Closed }

	public class GasTank
	{
		public bool IsConnected
		{
			get { return CheckConnection(); }
		}

		private ValveState _valve1State = ValveState.UnChecked;

		public ValveState Valve1State
		{
			get
			{
				if (_valve1State == ValveState.UnChecked)
				{
					_valve1State = GetValveState(1);
				}
				return _valve1State;
			}
			set
			{
				var result = SetValveState(1, value);
				if (result == true)
					_valve1State = value;
				else
					_valve1State = ValveState.Error;
			}
		}

		private ValveState _valve2State = ValveState.UnChecked;

		public ValveState Valve2State
		{
			get
			{
				if (_valve2State == ValveState.UnChecked)
				{
					_valve2State = GetValveState(2);
				}
				return _valve2State;
			}
			set
			{
				var result = SetValveState(2, value);
				if (result == true)
					_valve2State = value;
				else
					_valve2State = ValveState.Error;
			}
		}

		private bool CheckConnection()
		{
			var result = false;
			// check codes
			// result = GetConnectionStatus();
			if (result == false)
			{
				LogService.AddLog(LogType.Warnning, "가스탱크와 연결되어 있지 않습니다.");
				return false;
			}
			LogService.AddLog(LogType.Notice, "가스탱크와 연결확인.");
			return true;
		}

		private ValveState GetValveState(int valveNum)
		{
			ValveState vState = ValveState.UnChecked;
			if (IsConnected == false) return vState;

			switch (valveNum)
			{
				case 1:
					// check valveState1
					// ...
					vState = ValveState.Full;
					break;
				case 2:
					// check valveState2
					// ...
					vState = ValveState.Closed;
					break;
				default:
					LogService.AddLog(LogType.Warnning, "비정상 벨브번호: " + valveNum);
					break;
			}
			return vState;
		}

		private bool SetValveState(int valveNum, ValveState valveState)
		{
			if (IsConnected == false) return false;
			LogService.AddLog(LogType.Notice, "벨브[" + valveNum + "]제어: " + valveState.ToString());
			switch (valveNum)
			{
				case 1:
					return true;
				case 2:
					return true;
				default:
					LogService.AddLog(LogType.Warnning, "비정상 벨브제어시도, 벨브번호: " + valveNum);
					return false;
			}
		}
	}
}
