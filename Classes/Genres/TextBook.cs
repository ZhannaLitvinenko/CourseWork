using System;

namespace Курсова
{
	[Serializable]
	public class TextBook : Genre
	{
		private int paragraphAmount;
		public int ParagraphAmount
		{
			get
			{
				return paragraphAmount;
			}
			private set
			{
				paragraphAmount = value;
			}
		}

		public override int GetAmount()
		{
			return paragraphAmount;
		}
		public override string GetInfo()
		{
			string info = "Підручник - книга, що містить основи наукових знань з певної навчальної дисципліни відповідно до цілей навчання," +
				" встановлених програмою і вимогами дидактики. У підручнику втілюються важливі компоненти змісту освіти: знання про природу," +
				" суспільство, техніку, людину, способи діяльності, закони тощо. " +
				"Окрім того, він містить завдання, вказівки і методичні рекомендації.";

			return info;
		}
		public TextBook(int paragraphAmount) : base("Підручник")
		{
			ParagraphAmount = paragraphAmount;
		}
	}
}
