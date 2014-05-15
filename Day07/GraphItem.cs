using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Day07
{
	[DataContract]
	public class GraphItem
	{
		[DataMember]
		public float C1 { get; set; }
		[DataMember]
		public float C2 { get; set; }
		[DataMember]
		public float VPP { get; set; }
		[DataMember]
		public float IPP { get; set; }
		[DataMember]
		public float BIAS { get; set; }
		[DataMember]
		public float R { get; set; }
		[DataMember]
		public float RX { get; set; }

		public static void DataContractSerializ(List<GraphItem> items, string filename)
		{
			//FileStream stream = new FileStream(@"d:\bookDataB.bin", FileMode.Create, FileAccess.Write, FileShare.None);
			//DataContractSerializer dcs = new DataContractSerializer(typeof(AuthorB));
			//XmlDictionaryWriter xdw = XmlDictionaryWriter.CreateTextWriter(stream, Encoding.UTF8);
			//dcs.WriteObject(xdw, book);
			//stream.Close();

			var serializer = new DataContractSerializer(typeof(List<GraphItem>));
			FileStream stream = new FileStream(filename, FileMode.Create, FileAccess.Write, FileShare.None);
			//using (var writer = XmlDictionaryWriter.CreateBinaryWriter(stream))
			using (var writer = new BinaryWriter(stream))
			{
				serializer.WriteObject(stream, items);
			}
		}

		public static List<GraphItem> DataContractDeserialize(string filename)
		{
			var serializer = new DataContractSerializer(typeof(List<GraphItem>));
			using (var stream = new FileStream(filename, FileMode.Open))
			//using (var reader = XmlDictionaryReader.CreateBinaryReader(stream, XmlDictionaryReaderQuotas.Max))
			using (var reader = new BinaryReader(stream))
			{
				return (List<GraphItem>)serializer.ReadObject(stream);
			}
		}
	}
}
