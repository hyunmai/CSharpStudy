using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
	public class Program
	{
		static void Main(string[] args)
		{
			//BookA book = new BookA();
			//book.title = "Serialization Overview";
			//book.Author = new AuthorA();
			//book.Author.Name = "홍길동";
			//book.Author.Country = "Korea";

			// Xml Serialize
			//SerializationDemo.XmlSerialize(book);
			// Xml Deserialize
			//var fromXml = SerializationDemo.XmlDeserialize();

			//Binary Serialize 
			//SerializationDemo.BinarySerialize(book);
			// Binary Deserialize
			//var fromBinary = SerializationDemo.BinaryDeSerialize();

			//List<GraphItem> items = new List<GraphItem>();
			//for(int i=0; i < 100000; i++)
			//{
			//	var item = new GraphItem();
			//	item.C1 = 1.3f;
			//	item.C2 = 1.44f;
			//	items.Add(item);
			//}

			//GraphItem.DataContractSerializ(items, "d:\\testFile2.bin");

			var kk = GraphItem.DataContractDeserialize("d:\\testFile2.bin");
			var xx = kk;

			var Bs = new List<BookA>();

			var xxx = Bs.Where(b => b.Author.Name == "John").First();

			var book = new BookA();
			var au = book.Author;
			var books = book.Author.Books.Where(b => b.title == "Hello").Select(b => new { id = b.Author });
		}
	}
}
