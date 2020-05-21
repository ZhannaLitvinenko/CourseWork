using System;

namespace Курсова
{
	[Serializable]
	class HandBook : Genre
	{
		private int statementAmount;
		public int StatementAmount
		{
			get
			{
				return statementAmount;
			}
			private set
			{
				statementAmount = value;
			}
		}

		public override int GetAmount()
		{
			return statementAmount;
		}
		public override string GetInfo()
		{
			string info = "Довідник - видання, що містить короткі відомості наукового, виробничого або прикладного характеру," +
				" розташовані в певному порядку (алфавітному, систематичному, хронологічному і так далі ), " +
				"зручному для їх швидкого відшукання. Багато з них забезпечуються допоміжними покажчиками (алфавітним, наочним, іменним і ін.)";

			return info;
		}
		public HandBook(int statementAmount) : base("Довідник")
		{
			StatementAmount = statementAmount;
		}
	}
}
