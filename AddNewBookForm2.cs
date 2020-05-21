using System;
using System.Drawing;
using System.Windows.Forms;

namespace Курсова
{
	public partial class AddNewBookForm2 : Form
	{
		private Book book;
		public AddNewBookForm2()
		{
			InitializeComponent();
		}
		public AddNewBookForm2(Book book) : this()
		{
			this.book = book;
			genreComboBox.SelectedIndex = 0;
		}
		private bool AllFieldsAreNonEmpty()
		{
			//Перевіряємо, чи можна привести поле "кількість ..." до типу int
			int amount;
			try
			{
				amount = Convert.ToInt32(amountTextBox.Text);
			}
			catch (Exception) { amount = 0; }

			//Перевіряємо, чи всі поля заповнені
			if (genreComboBox.Text != "" && amount != 0)
				return true;

			return false;
		}
		private Genre CreateGenre()
		{
			Genre genre = null;
			//записуємо кількість ... у змінну
			int amount = Convert.ToInt32(amountTextBox.Text);
			//створюємо потрібний екземпляр із приведенням до базового типу
			switch (genreComboBox.SelectedItem)
			{
				case "Антологія":
					genre = new Anthology(amount);
					break;
				case "Атлас":
					genre = new Atlas(amount);
					break;
				case "Каталог":
					genre = new Catalog(amount);
					break;
				case "П'єса":
					genre = new DramaticalPiece(amount);
					break;
				case "Довідник":
					genre = new HandBook(amount);
					break;
				case "Роман":
					genre = new Novel(amount);
					break;
				case "Поема":
					genre = new Poem(amount);
					break;
				case "Збірник задач":
					genre = new TaskBook(amount);
					break;
				case "Підручник":
					genre = new TextBook(amount);
					break;
			}

			return genre;
		}
		private void genreComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			//Перевіряємо, який жанр обрано, в залежності від цього змінюємо лейбл:
			switch (genreComboBox.SelectedItem)
			{
				case "Антологія":
					amountLabel.Text = "Кількість творів:";
					break;
				case "Атлас":
					amountLabel.Text = "Кількість карт:";
					break;
				case "Каталог":
					amountLabel.Text = "Кількість товарів:";
					break;
				case "П'єса":
					amountLabel.Text = "Кількість актів:";
					break;
				case "Довідник":
					amountLabel.Text = "Кількість записів:";
					break;
				case "Роман":
					amountLabel.Text = "Кількість глав:";
					break;
				case "Поема":
					amountLabel.Text = "Кількість віршів:";
					break;
				case "Збірник задач":
					amountLabel.Text = "Кількість задач:";
					break;
				case "Підручник":
					amountLabel.Text = "Кількість параграфів:";
					break;
			}
			//виставляємо позицію поля для введення відносно лейблу:
			amountTextBox.Location = new Point(amountLabel.Location.X + amountLabel.Size.Width + 5,
				amountTextBox.Location.Y);
		}
		private void AddNewButton_Click(object sender, EventArgs e)
		{
			if (AllFieldsAreNonEmpty())
			{
				//результат, чи можна надати цій книзі таке значення жанру
				bool genreResult = true;
				//Отримуємо потрібний жанр із полів:
				Genre genre = CreateGenre();
				//Пробуємо записати такий у книгу
				book.SetGenre(out genreResult, genre);
				//Якщо жанр записаний, переходимо далі, якщо ні -- виводимо попередження
				if (genreResult)
				{
					//Закриваємо цю форму:
					Dispose();
					//Переходимо на наступну форму введення книги:
					new AddNewBookForm3(book).ShowDialog();
				}
				else
				{
					MessageBox.Show($"Обраний жанр \"{genre.Name}\" не може бути наданий книзі типу \"{book.Type}\".",
						"Попередження");
				}
			}
			else
				MessageBox.Show("Заповніть усі поля.", "Попередження");
		}
	}
}
