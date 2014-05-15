using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day07
{
	[Serializable]
	public class BookA
	{
		public String title;
		public AuthorA Author { get; set; }
	}

	[Serializable]
	public class AuthorA
	{
		public string Name { get; set; }
		public string Country { get; set; }

		public List<BookA> Books { get; set; }
	}

	[DataContract]
	public class BookB
	{
		[DataMember]
		public String title;
		[DataMember]
		public AuthorB Author { get; set; }
	}

	[DataContract]
	public class AuthorB
	{
		[DataMember]
		public string Name { get; set; }

		public string Country { get; set; }
	}


	public static class SerializationDemo
	{
		public static void XmlSerialize(BookA book)
		{
			System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(BookA));
			System.IO.StreamWriter file = new System.IO.StreamWriter(@"d:\bookInfo.xml");
			writer.Serialize(file, book);
			file.Close();
		}

		public static BookA XmlDeserialize()
		{
			System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(BookA));
			System.IO.StreamReader file = new System.IO.StreamReader(@"d:\bookInfo.xml");
			BookA book = (BookA)reader.Deserialize(file);
			file.Close();
			return book;
		}

		public static void BinarySerialize(BookA book)
		{
			IFormatter formatter = new BinaryFormatter();
			Stream stream = new FileStream(@"d:\bookData.bin", FileMode.Create, FileAccess.Write, FileShare.None);
			formatter.Serialize(stream, book);
			stream.Close();
		}

		public static BookA BinaryDeSerialize()
		{
			IFormatter formatter = new BinaryFormatter();
			Stream stream = new FileStream(@"d:\bookData.bin", FileMode.Open);
			var obj = formatter.Deserialize(stream) as BookA;
			stream.Close();
			return obj;
		}

		public static void DataContractSerializ(BookB book, string filename, string format)
		{
			//FileStream stream = new FileStream(@"d:\bookDataB.bin", FileMode.Create, FileAccess.Write, FileShare.None);
			//DataContractSerializer dcs = new DataContractSerializer(typeof(AuthorB));
			//XmlDictionaryWriter xdw = XmlDictionaryWriter.CreateTextWriter(stream, Encoding.UTF8);
			//dcs.WriteObject(xdw, book);
			//stream.Close();

			var serializer = new DataContractSerializer(typeof(BookB));
			FileStream stream = new FileStream(@"d:\bookDataB.bin", FileMode.Create, FileAccess.Write, FileShare.None);
			//using (var writer = XmlDictionaryWriter.CreateBinaryWriter(stream))
			using (var writer = new BinaryWriter(stream))
			{
				serializer.WriteObject(stream, book);
			}
		}

		public static BookB DataContractDeserialize()
		{
			var serializer = new DataContractSerializer(typeof(BookB));
			using (var stream = new FileStream(@"d:\bookData.bin", FileMode.Open))
			//using (var reader = XmlDictionaryReader.CreateBinaryReader(stream, XmlDictionaryReaderQuotas.Max))
			using (var reader = new BinaryReader(stream))
			{
				return (BookB)serializer.ReadObject(stream);
			}
		}
	}
}
