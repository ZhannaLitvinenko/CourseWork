using System;

namespace Курсова
{
	[Serializable]
	public class Atlas : Genre
	{
		private int mapAmount;
		public int MapAmount
		{
			get
			{
				return mapAmount;
			}
			private set
			{
				mapAmount = value;
			}
		}

		public override int GetAmount()
		{
			return mapAmount;
		}
		public override string GetInfo()
		{
			string info = "Географічний атлас - систематизоване зібрання карт, що виконане за загальною програмою, як єдиний цілісний твір." +
				"В атласі карти тематич­но поєднані між собою, взаємно узгоджені й доповнюють одна одну. " +
				"Для атласів характерним є один набір проекцій та масштабів. На картах атласів використовують загальні прийоми генералізації," +
				" єдині системи умовних позначень, шрифти, способи графічного й кольорового оформлення." +
				" Атла­си оформляють в вигляді окремих альбомів або книжок." +
				" Крім карт, атласи містять пояснювальні тексти, довідкові матеріали, графіки та фотографії, що доповнюють карти.";

			return info;
		}

		public Atlas(int mapAmount) : base("Атлас")
		{
			MapAmount = mapAmount;
		}
	}
}
