using System;

namespace Курсова
{
	[Serializable]
	public class Genre
	{
		private string name;
		public string Name
		{
			get
			{
				return name;
			}
			private set
			{
				name = value;
			}
		}

		public virtual int GetAmount()
		{
			return 0;
		}
		public virtual string GetInfo()
		{
			return "";
		}
		public Genre(string name)
		{
			Name = name;
		}
	}
}