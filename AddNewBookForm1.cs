using System;
using System.Windows.Forms;

namespace Курсова
{
	public partial class AddNewBookForm1 : Form
	{
		private Book book;
		public AddNewBookForm1()
		{
			InitializeComponent();
			book = null;
		}

		private bool AllFieldsAreNonEmpty()
		{
			//Перевіряємо, чи можна привести поле "рік" до типу int
			int year;
			try
			{
				year = Convert.ToInt32(yearTextBox.Text);
			}
			catch (Exception) { year = 0; }

			//Перевіряємо, чи всі поля заповнені
			if (authorTextBox.Text != "" && nameTextBox.Text != "" &&  year != 0 && typeComboBox.Text != "")
				return true;

			return false;
		}
		private Book CreateBook()
		{
			Book book = null;

			switch (typeComboBox.Text)
			{
				case "Художня книга":
					book = new Fiction();
					break;
				case "Навчальна книга":
					book = new StudyBook();
					break;
				case "Спеціальна книга":
					book = new SpecialBook();
					break;
			}

			return book;
		}
		private void AddNewButton_Click(object sender, EventArgs e)
		{
			if (AllFieldsAreNonEmpty())
			{
				//Заповнюємо книгу з полів:
				book = CreateBook();
				book.Author = authorTextBox.Text;
				book.Name = nameTextBox.Text;
				book.Year = Convert.ToInt32(yearTextBox.Text);
				//Закриваємо цю форму:
				Dispose();
				//Переходимо на наступну форму введення книги:
				new AddNewBookForm2(book).ShowDialog();
				
			}
			else
				MessageBox.Show("Заповніть усі поля.", "Попередження");

		}
	}
}
