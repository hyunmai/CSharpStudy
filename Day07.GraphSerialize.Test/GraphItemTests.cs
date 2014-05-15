using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Day07.GraphSerialize.Test
{
	[TestClass]
	public class GraphItemTests
	{
		[TestMethod]
		public void DataContractWriteTest()
		{
			List<GraphItem> items = new List<GraphItem>();
			for (int i = 0; i < 100000; i++)
			{
				var item = new GraphItem();
				item.C1 = 1.3f;
				item.C2 = 1.44f;
				items.Add(item);
			}

			var result = GraphItem.DataContractSerializ(items, "d:\\testFile2.bin");
			Assert.IsTrue(result);
			var kk = GraphItem.DataContractDeserialize("d:\\testFile2.bin");

			Assert.IsTrue((kk[0].C1 == items[0].C1));
		}

		public void DataContractReadTest()
		{

		}
	}
}
