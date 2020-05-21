using System;

namespace Курсова
{
	[Serializable]
	public class Novel : Genre
	{
		private int chapterAmount;
		public int ChapterAmount
		{
			get
			{
				return chapterAmount;
			}
			private set
			{
				chapterAmount = value;
			}
		}

		public override int GetAmount()
		{
			return chapterAmount;
		}
		public override string GetInfo()
		{
			string info = "Роман — великий за обсягом і складний за будовою епічний твір, " +
				"у якому широко охоплені важливі й складні суспільні про­цеси, всебічно і в розвитку показані численні персонажі. " +
				"У романі розвивається кілька сюжетних ліній, пов’язаних з долею головних героїв.";

			return info;
		}
		public Novel(int chapterAmount) : base("Роман")
		{
			ChapterAmount = chapterAmount;
		}
	}
}
