using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Day10.GasTankBasic.Test
{
	[TestClass]
	public class GasTankTests
	{
		private static GasTank GS1;
		private static GasTank GS2;
		[TestMethod]
		public void GasTank_ConnectionTest()
		{
			GS1 = new GasTank("난방가스탱크", "192.168.0.22:777");
			GS2 = new GasTank("비상발전가스탱크", "192.168.0.23:777");
			var result1 = GS1.CheckConnection();
			Assert.IsTrue(result1);
			var result2 = GS2.CheckConnection();
			Assert.IsTrue(result2);
		}

		[TestMethod]
		public void GasTank_ValveStateTest()
		{
			if (GS1 != null && GS1.CheckConnection())
			{
				var result1 = GS1.GetValveState(1);
				Assert.IsTrue(result1 == ValveState.Full);

				var result2 = GS1.GetValveState(2);
				Assert.IsTrue(result2 == ValveState.Full);
			}
			if (GS2 != null && GS2.CheckConnection())
			{
				var result1 = GS2.GetValveState(1);
				Assert.IsTrue(result1 == ValveState.Full);

				var result2 = GS2.GetValveState(2);
				Assert.IsTrue(result2 == ValveState.Full);
			}
		}
	}
}
