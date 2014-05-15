using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Soft.Windows.Forms
{
	public class TextBox : UIElement
	{
		public string Text { get; set; }

		public override void Render()
		{
			//base.Render();
			Console.WriteLine("TextBox, Text: " + Text);
		}
	}
}
