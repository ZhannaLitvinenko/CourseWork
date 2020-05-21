using System;

namespace Курсова
{
	[Serializable]
	class TaskBook : Genre
	{
		private int taskAmount;
		public int TaskAmount
		{
			get
			{
				return taskAmount;
			}
			private set
			{
				taskAmount = value;
			}
		}

		public override int GetAmount()
		{
			return taskAmount;
		}
		public override string GetInfo()
		{
			string info = "У збірнику задач, на відміну від збірки, авторів декілька, це - часто профільні видання," +
				" у яких знаходиться перелік задач для виконання із деякого предмету.";

			return info;
		}
		public TaskBook(int taskAmount) : base("Збірник задач")
		{
			TaskAmount = taskAmount;
		}
	}
}
