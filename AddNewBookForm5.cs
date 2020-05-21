using System;
using System.Windows.Forms;

namespace Курсова
{
	public partial class AddNewBookForm5 : Form
	{
		private Book book;
		public AddNewBookForm5()
		{
			InitializeComponent();
		}
		public AddNewBookForm5(Book book) : this()
		{
			this.book = book;
		}

		private BookSize CreateBookSize()
		{
			int length = Convert.ToInt32(lengthTextBox.Text),
				width = Convert.ToInt32(widthTextBox.Text),
				height = Convert.ToInt32(heightTextBox.Text);

			return new BookSize(length, width, height);
		}
		private bool AllFieldsAreNonEmpty()
		{
			//Перевіряємо, чи можна привести поля довжини, ширини та висоти до типу int
			int length, width, height;
			try
			{
				length = Convert.ToInt32(lengthTextBox.Text);
				width = Convert.ToInt32(widthTextBox.Text);
				height = Convert.ToInt32(heightTextBox.Text);
			}
			catch (Exception)
			{
				length = 0;
				width = 0;
				height = 0;
			}

			//Перевіряємо, чи всі поля заповнені
			if (length != 0 && width != 0 && height != 0)
				return true;

			return false;

		}

		private void CreateButton_Click(object sender, EventArgs e)
		{
			if (AllFieldsAreNonEmpty())
			{
				//Заповнюємо книгу з полів
				book.BookSize = CreateBookSize();
				//Закриваємо форму
				Dispose();
				//Додаємо кінцевий варіант книги у сховище
				Data.Books.Add(book);
				Data.Save();
			}
			else
				MessageBox.Show("Заповніть усі поля.", "Попередження");
		}
	}
}
