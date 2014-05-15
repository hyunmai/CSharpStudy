using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Soft.Windows.Forms
{
	public class UIElement : Object
	{
		public UIElement()
		{

		}
		public UIElement(double width, double height)
		{
			Width = width;
			Height = height;
		}
		public UIElement(string name, double width, double height)
		{
			this.Name = name;
			this.Width = width;
			this.Height = height;
		}

		public string Name { get; set; }
		public double Width { get; set; }
		public double Height { get; set; }

		public virtual void Render()
		{
			Console.WriteLine("UIElementName: " + Name);
		}
	}
}
