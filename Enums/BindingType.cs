using System;

namespace Курсова
{
	[Serializable]
	public enum BindingType
	{
		//перепліт 7БЦ (целофанований)
		Binding7BC,
		//перепліт 7Б
		Binding7B,
		//інтегральний перепліт
		IntegralBinding,
		//французький перепліт
		FrenchBinding,
		//перепліт подвійною дротовою петлею (Wire-O)
		WireOBinding,
		//клейове безшовне з'єднання
		GlueSeamless,
		//скобкове з'єднання
		Stapling,
		//зшивання
		PaperLacing,
		//брошурування
		Stitching
	}
}
