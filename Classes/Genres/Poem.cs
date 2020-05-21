using System;

namespace Курсова
{
	[Serializable]
	public class Poem : Genre
	{
		private int verseAmount;
		public int VerseAmount
		{
			get
			{
				return verseAmount;
			}
			private set
			{
				verseAmount = value;
			}
		}

		public override int GetAmount()
		{
			return verseAmount;
		}
		public override string GetInfo()
		{
			string info = "Поема - це ліро - епічний віршований твір, у якому зображені значні події і яскраві характери," +
				" а розповідь героїв супроводжується розкриттям авторських переживань і роздумів.";

			return info;
		}

		public Poem(int verseAmount) : base("Поема")
		{
			VerseAmount = verseAmount;
		}
	}
}
