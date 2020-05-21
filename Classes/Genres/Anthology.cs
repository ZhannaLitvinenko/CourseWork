using System;

namespace Курсова
{
	[Serializable]
	public class Anthology : Genre
	{
		private int writingsAmount;
		public int WritingsAmount
		{
			get
			{
				return writingsAmount;
			}
			private set
			{
				writingsAmount = value;
			}
		}

		public override int GetAmount()
		{
			return writingsAmount;
		}
		public override string GetInfo()
		{
			string info = "Антологія - це неперіодичний збірник, що включає обрані літературні художні твори(або витяги з них), переважно віршовані.";
			return info;
		}
		public Anthology(int writingsAmount) : base("Антологія")
		{
			WritingsAmount = writingsAmount;
		}
	}
}
