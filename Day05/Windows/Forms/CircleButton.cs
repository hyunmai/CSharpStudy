using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Soft.Windows.Forms
{
	public class CircleButton : Button
	{
		public override void Render()
		{
			Console.WriteLine("Circle button Caption: " + this.Caption);
		}
	}
}
