using F1Soft.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day05
{
	class Program
	{
		static void Main(string[] args)
		{
			var panel = new Panel();
			panel.Name = "MyPanel";
			var btn1 = new Button();
			btn1.Name = "MyBtn";
			btn1.Caption = "OK";
			panel.Children.Add(btn1);

			//var tb1 = new TextBox();
			//tb1.Name = "MyTb";
			//tb1.Text = "MyTextBox";
			//panel.Children.Add(tb1);

			//var cb1 = new CircleButton();
			//cb1.Name = "MyCB";
			//cb1.Caption = "Circle";
			//panel.Children.Add(cb1);

			panel.Render();

			Console.WriteLine("value: " + btn1);

			var btn2 = new Button("MySecond", 64, 64, "hi");
			var btn3 = new Button(btn2);

			var btn4 = btn2 + btn3;

			var ue = new UIElement();
		}
	}
}
