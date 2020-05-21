using System;

namespace Курсова
{
	[Serializable]
	class SpecialBook : Book
	{
		public SpecialBook() : base("Спеціальна книга") { }
		public override void SetGenre(out bool result, Genre genre)
		{
			bool res = false;

			//Спеціальна книга може бути: каталогом, довідником
			if (genre.Name == "Каталог" || genre.Name == "Довідник")
			{
				res = true;
				Genre = genre;
			}

			result = res;
		}
	}
}
