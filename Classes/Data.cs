using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Курсова
{
	public static class Data
	{
		public static List<Book> Books = new List<Book>();
		private const string fileName = "books.txt";

		public static void Read()
		{
			if (Books.Count == 0)
			{
				BinaryFormatter binFormatter = new BinaryFormatter();

				using (Stream stream = new FileStream(fileName, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
				{
					if (stream.Length > 0)
						Books = (List<Book>)binFormatter.Deserialize(stream);
				}
			}
			else
				MessageBox.Show("Список книжок уже прочитаний.", "Попередження");
		}
		public static void Save()
		{
			BinaryFormatter binFormatter = new BinaryFormatter();

			using (Stream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None))
			{
				binFormatter.Serialize(stream, Books);
			}
		}
	}
}
