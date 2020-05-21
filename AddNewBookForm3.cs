using System;
using System.Windows.Forms;

namespace Курсова
{
	public partial class AddNewBookForm3 : Form
	{
		private Book book;
		public AddNewBookForm3()
		{
			InitializeComponent();
		}
		public AddNewBookForm3(Book book) : this()
		{
			this.book = book;
		}
		private CoverType GetCoverType()
		{
			CoverType type = CoverType.SolidCardboardEdged;
			//обираємо тип палітурки в залежності від того, який обраний:
			switch (coverTypeComboBox.SelectedItem)
			{
				case "Суцільно картонна, обрізна":
					type = CoverType.SolidCardboardEdged;
					break;
				case "Суцільно картонна, м’яка з кантом":
					type = CoverType.SolidCardboardSoftEdged;
					break;
				case "Суцільно паперова, тверда з кантом":
					type = CoverType.SolidPaperEdged;
					break;
				case "Суцільно тканинна, м’яка з кантом":
					type = CoverType.SolidFabricSoftEdged;
					break;
				case "Суцільно тканинна, тверда з кантом":
					type = CoverType.SolidFabricEdged;
					break;
				case "Складова, тверда з кантом":
					type = CoverType.ComponentEdged;
					break;
				case "Пластмасова м’яка":
					type = CoverType.PlasticSoft;
					break;
				case "Пластмасова, напівжорстка":
					type = CoverType.PlasticSemiRigid;
					break;
				case "Пластмасова, жорстка":
					type = CoverType.PlasticHard;
					break;
			}

			return type;
		}
		private BindingType GetBindingType()
		{
			BindingType type = BindingType.Binding7BC;
			//обираємо тип переплетення в залежності від того, який обраний:
			switch (bindingTypeComboBox.SelectedItem)
			{
				case "Переплетення 7БЦ (целофанованове)":
					type = BindingType.Binding7BC;
					break;
				case "Переплетення 7Б":
					type = BindingType.Binding7B;
					break;
				case "Інтегральне переплетення":
					type = BindingType.IntegralBinding;
					break;
				case "Французьке переплетення":
					type = BindingType.FrenchBinding;
					break;
				case "Wire-O переплетення":
					type = BindingType.WireOBinding;
					break;
				case "Клейове безшовне з'єднання":
					type = BindingType.GlueSeamless;
					break;
				case "Скобкове з'єднання":
					type = BindingType.Stapling;
					break;
				case "Зшивання":
					type = BindingType.PaperLacing;
					break;
				case "Брошурування":
					type = BindingType.Stitching;
					break;
			}

			return type;
		}
		private bool AllFieldsAreNonEmpty()
		{
			//Перевіряємо, чи можна привести поле вага до типу int
			int weight;
			try
			{
				weight = Convert.ToInt32(weightTextBox.Text);
			}
			catch (Exception) { weight = 0; }

			//Перевіряємо, чи всі поля заповнені
			if (coverTypeComboBox.Text != "" && bindingTypeComboBox.Text != "" && weight != 0)
				return true;

			return false;
		}
		private void AddNewButton_Click(object sender, EventArgs e)
		{
			if (AllFieldsAreNonEmpty())
			{
				//Заповнюємо книгу з полів
				book.Weight = Convert.ToInt32(weightTextBox.Text);
				book.CoverType = GetCoverType();
				book.BindingType = GetBindingType();
				//Закриваємо форму
				Dispose();
				//Переходимо на наступну форму введення
				new AddNewBookForm4(book).ShowDialog();
			}
			else
				MessageBox.Show("Заповніть усі поля.", "Попередження");
		}
	}
}
