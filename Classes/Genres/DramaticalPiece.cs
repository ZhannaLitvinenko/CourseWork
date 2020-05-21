using System;

namespace Курсова
{
	[Serializable]
	public class DramaticalPiece : Genre
	{
		private int actAmount;
		public int ActAmount
		{
			get
			{
				return actAmount;
			}
			private set
			{
				actAmount = value;
			}
		}

		public override int GetAmount()
		{
			return actAmount;
		}
		public override string GetInfo()
		{
			string info = "П'єса - це літературний твір, зазвичай драматичний. Форма передбачає наявність великої кількості діалогів (монологів)," +
						" написаних у формі реплік. Як правило, п'єса створюється з метою її трансформації в ще один вид мистецтва - театральну виставу." +
						"П'єси можуть бути драматичні, комедійні, трагічні та ін. Переважає, усе ж таки, драматичний жанр.";

			return info;
		}

		public DramaticalPiece(int actAmount) : base("П'єса")
		{
			ActAmount = actAmount;
		}
	}
}
