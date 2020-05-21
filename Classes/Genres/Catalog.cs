using System;

namespace Курсова
{
	[Serializable]
	public class Catalog : Genre
	{
		private int goodsAmount;
		public int GoodsAmount
		{
			get
			{
				return goodsAmount;
			}
			private set
			{
				goodsAmount = value;
			}
		}

		public override int GetAmount()
		{
			return goodsAmount;
		}
		public override string GetInfo()
		{
			string info = "Каталог — перелік товарів (послуг) з їхнім описом. " +
				"Дані про товар можуть включати текстову описову інформацію, значення характеристик, " +
				"зображення, відомості про класифікацію, мультимедійну інформацію, " +
				"інформацію про ціни і інше залежно від призначення і носія.";

			return info;
		}
		public Catalog(int goodsAmount) : base("Каталог")
		{
			GoodsAmount = goodsAmount;
		}
	}
}