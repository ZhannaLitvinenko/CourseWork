using System;
using System.Windows.Forms;

namespace Курсова
{
	public partial class MenuForm : Form
	{
		public MenuForm()
		{
			InitializeComponent();

			if (Data.Books.Count == 0)
				Data.Read();
		}

		private void ShowAllButton_Click(object sender, EventArgs e)
		{
			new ShowAllBooksForm().ShowDialog();
		}

		private void AddNewButton_Click(object sender, EventArgs e)
		{
			new AddNewBookForm1().ShowDialog();
		}

		private void ExitButton_Click(object sender, EventArgs e)
		{
			Dispose();
		}
	}
}
