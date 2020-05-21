using System;

namespace Курсова
{
	[Serializable]
	public class StudyBook : Book
	{
		public StudyBook() : base("Навчальна книга") { }
		public override void SetGenre(out bool result, Genre genre)
		{
			bool res = false;

			//Навчальна книга може бути: підручником, збірником задач
			if (genre.Name == "Підручник" || genre.Name == "Збірник задач")
			{
				res = true;
				Genre = genre;
			}

			result = res;
		}
	}
}
