using System;

namespace Курсова
{
	[Serializable]
	public struct BookSize
	{
		public int Length { get; private set; }
		public int Width { get; private set; }
		public int Height { get; private set; }

		public BookSize(int length, int width, int height)
		{
			Length = length;
			Width = width;
			Height = height;
		}
	}
}
