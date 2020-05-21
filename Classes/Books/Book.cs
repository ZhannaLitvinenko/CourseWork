using System;

namespace Курсова
{
	[Serializable]
	public class Book
	{
		public string Type { get; private set; }
		public string Name { get; set; }
		public string Author { get; set; }
		public int Year { get; set; }
		public int Weight { get; set; }
		public Genre Genre { get; protected set; }
		public virtual void SetGenre(out bool result, Genre genre)
		{
			result = false;
		}
		public BookSize BookSize { get; set; }
		public PaperType PaperType { get; set; }
		public CoverType CoverType { get; set; }
		public BindingType BindingType { get; set; }

		public Book(string type)
		{
			Type = type;
		}
		public override string ToString()
		{
			return $"{Author} \"{Name}\", {Year}р.";
		}
	}
}
