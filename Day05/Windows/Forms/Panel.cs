using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Soft.Windows.Forms
{
	public class Panel : UIElement
	{
		public Panel()
		{
			Children = new List<UIElement>();
		}
		public List<UIElement> Children { get; set; }

		public override void Render()
		{
			Console.WriteLine(this);
			foreach (var element in Children)
			{
				element.Render();
			}
		}

		public override string ToString()
		{
			return "Hey, I'm Panel";
		}
	}
}
