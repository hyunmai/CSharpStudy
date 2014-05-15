using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Soft.Windows.Forms
{
	public class Button : UIElement
	{
		public Button()
		{

		}
		public Button(string name, double width, double height, string caption) : base(name, width, height)
		{
			this.Caption = caption;
		}

		public Button(Button source) : base(source.Name, source.Width, source.Height)
		{
			this.Caption = source.Caption;
		}

		public string Caption { get; set; }
		public bool Enabled { get; set; }

		public override void Render()
		{
			Console.WriteLine(this);
		}

		public override string ToString()
		{
			return "Name: " + this.Name + " Width: " + this.Width; // ....
		}

		public static Button operator +(Button c1, Button c2)
		{
			return new Button(c1.Name, c1.Width + c2.Width, c1.Height + c2.Height, c1.Caption);
		}
	}
}
