using System;

namespace Курсова
{
	[Serializable]
	public struct PaperType
	{
		//щільність(гр./м.кв.)
		public int Density { get; private set; }
		//білизна (у %)
		public int Whiteness { get; private set; }
		//Тип відбивання світла (мат чи глянець)
		public PaperLightReflectionType Name { get; private set; }

		public PaperType(int density, int whiteness, PaperLightReflectionType ligthReflectionType)
		{
			Density = density;
			Whiteness = whiteness;
			Name = ligthReflectionType;
		}
	}
}
