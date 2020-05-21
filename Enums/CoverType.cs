using System;

namespace Курсова
{
	[Serializable]
	public enum CoverType
	{
		//Суцільно картонна, обрізна
		SolidCardboardEdged,
		//Суцільно картонна, м’яка з кантом
		SolidCardboardSoftEdged,
		//Суцільно паперова, тверда з кантом
		SolidPaperEdged,
		//Суцільно тканинна, м’яка з кантом
		SolidFabricSoftEdged,
		//Суцільно тканинна, тверда з кантом.
		SolidFabricEdged,
		//Складова, тверда з кантом
		ComponentEdged,
		//Пластмасова м’яка
		PlasticSoft,
		//Пластмасова, напівжорстка
		PlasticSemiRigid,
		//Пластмасова, жорстка
		PlasticHard
	}
}
