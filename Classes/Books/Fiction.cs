using System;

namespace Курсова
{
	[Serializable]
	public class Fiction : Book
	{
		public Fiction() : base("Художня книга") { }
		public override void SetGenre(out bool result, Genre genre)
		{
			bool res = false;

			//Художня книга може бути: антологією, п'єсою, романом, поемою
			if (genre.Name == "Антологія" || genre.Name == "П'єса" || genre.Name == "Роман" || genre.Name == "Поема")
			{
				res = true;
				Genre = genre;
			}

			result = res;
		}
	}
}
