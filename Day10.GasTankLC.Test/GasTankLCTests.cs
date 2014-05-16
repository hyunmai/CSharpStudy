using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day10.Logging;

namespace Day10.GasTankLC.Test
{
	[TestClass]
	public class GasTankLCTests
	{
		[TestMethod]
		public void GasTankLCTest()
		{
			Logging.LogService.SetLogger(new DebugLogger());
			// MockupGonnector Test
			var connector1 = new MockGasTankConnector(false, ValveState.Full, ValveState.Half);
			var gs1 = new GasTank("난방가스탱크", connector1);

			var connector2 = new MockGasTankConnector(true, ValveState.Closed, ValveState.Half);
			var gs2 = new GasTank("발전용가스탱크", connector2);

			// MockupGonnector Test
			//var connector1 = new SerialGasTankConnector();
			//var gs1 = new GasTank("난방가스탱크", connector1);

			//var connector2 = new SerialGasTankConnector();
			//var gs2 = new GasTank("발전용가스탱크", connector2);

			Assert.IsTrue(gs1.CheckConnection() == false);
			Assert.IsTrue(gs2.CheckConnection() == true);

			Assert.AreEqual(gs2.GetValveState(1), ValveState.Closed);
			Assert.AreEqual(gs2.GetValveState(2), ValveState.Half);

			gs2.SetValveState(1, ValveState.Half);
			gs2.SetValveState(2, ValveState.Closed);

			Assert.AreEqual(gs2.GetValveState(1), ValveState.Half);
			Assert.AreEqual(gs2.GetValveState(2), ValveState.Closed);
		}
	}
}
