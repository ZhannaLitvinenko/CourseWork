using System;
using System.Windows.Forms;

namespace Курсова
{
	public partial class AddNewBookForm4 : Form
	{
		private Book book;
		public AddNewBookForm4()
		{
			InitializeComponent();
		}
		public AddNewBookForm4(Book book) : this()
		{
			this.book = book;
		}
		private PaperType CreatePaperType()
		{
			//визначаємо глянцевість/матовість
			PaperLightReflectionType reflectionType = PaperLightReflectionType.Glossy;
			switch (lightReflectionComboBox.SelectedItem)
			{
				case "Матовий папір":
					reflectionType = PaperLightReflectionType.Matte;
					break;
				case "Глянцевий папір":
					reflectionType = PaperLightReflectionType.Glossy;
					break;
			}
			//визначаємо білизну та щільність із полів
			int whiteness = Convert.ToInt32(whitenessTextBox.Text),
				density = Convert.ToInt32(densityTextBox.Text);

			return new PaperType(density, whiteness, reflectionType);
		}
		private bool AllFieldsAreNonEmpty()
		{
			//Перевіряємо, чи можна привести поля білизни та щільності до типу int
			int whiteness, density;
			try
			{
				whiteness = Convert.ToInt32(whitenessTextBox.Text);
				density = Convert.ToInt32(densityTextBox.Text);
			}
			catch (Exception)
			{
				whiteness = 0;
				density = 0;
			}

			//Перевіряємо, чи всі поля заповнені
			if (lightReflectionComboBox.Text != "" && whiteness != 0 && density != 0)
				return true;

			return false;
		}
		private void AddNewButton_Click(object sender, EventArgs e)
		{
			if (AllFieldsAreNonEmpty())
			{
				//Заповнюємо книгу з полів
				book.PaperType = CreatePaperType();
				//Закриваємо форму
				Dispose();
				//Переходимо на наступну форму введення
				new AddNewBookForm5(book).ShowDialog();
			}
			else
				MessageBox.Show("Заповніть усі поля.", "Попередження");
		}
	}
}
