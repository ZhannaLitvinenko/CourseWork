using CourseWork.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Курсова
{
	public partial class ShowAllBooksForm : Form
	{
		private List<Book> books;
		public ShowAllBooksForm()
		{
			InitializeComponent();

			if (Data.Books.Count == 0)
				Data.Read();

			books = Data.Books;

			FillListViewFromBooks();
		}

		private void FillListViewFromBooks()
		{
			ImageList images = new ImageList();
			images.ImageSize = new Size(30, 30);
			Image ico = Resources.book;
			images.Images.Add("book", ico);
			//додаємо усі книги із ліста у listview
			foreach (Book book in books)
			{
				booksListView.Items.Add(book.ToString(), "book");
			}

			booksListView.LargeImageList = images;
		}
		private Book GetSelectedBook()
		{
			//беремо першу із виділених книг та забираємо за таким індексом із ліста
			Book selectedBook;
			try
			{
				selectedBook = Data.Books[booksListView.SelectedIndices[0]];
			}
			catch (Exception)
			{
				selectedBook = null;
			}

			return selectedBook;
		}
		private void ClearSelectedBookLabels()
		{
			bookTypeLabel.Text = "-----";
			authorLabel.Text = "-----";
			nameLabel.Text = "-----";
			genreLabel.Text = "-----";
			yearLabel.Text = "-----";
		}
		private void booksListView_SelectedIndexChanged(object sender, EventArgs e)
		{
			Book selectedBook = GetSelectedBook();
			//якщо книга існує та отримана, виводимо:
			if (selectedBook != null)
			{
				bookTypeLabel.Text = selectedBook.Type;
				authorLabel.Text = selectedBook.Author;
				nameLabel.Text = selectedBook.Name;
				genreLabel.Text = selectedBook.Genre.Name;
				yearLabel.Text = selectedBook.Year.ToString();
			}
			else
			{
				//якщо книга не обрана -- виводимо пусті поля
				ClearSelectedBookLabels();
			}
		}
		private void showBookButton_Click(object sender, EventArgs e)
		{
			//Якщо книга обрана -- виводимо інформацію про неї через наступну форму
			Book selectedBook = GetSelectedBook();
			if (selectedBook != null)
				new FullBookInformation(selectedBook).ShowDialog();
		}
		private void deleteButton_Click(object sender, EventArgs e)
		{
			//отримуємо виділений елемент та видаляємо зі сховища
			Data.Books.Remove(GetSelectedBook());
			//сховище зберігаємо
			Data.Save();
			//оновлюємо цю сторінку
			books = Data.Books;
			booksListView.Items.Clear();
			ClearSelectedBookLabels();
			FillListViewFromBooks();
		}
	}
}
