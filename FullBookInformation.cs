using System;
using System.Windows.Forms;

namespace Курсова
{
	public partial class FullBookInformation : Form
	{
		private Book book;
		public FullBookInformation()
		{
			InitializeComponent();
		}
		public FullBookInformation(Book book) : this()
		{
			this.book = book;
			FillAllLabels();
		}
		private string GetCoverTypeString()
		{
			string coverType = "";
			switch (book.CoverType)
			{
				case CoverType.SolidCardboardEdged:
					coverType = "Суцільно картонна, обрізна";
					break;
				case CoverType.SolidCardboardSoftEdged:
					coverType = "Суцільно картонна, м’яка з кантом";				
					break;
				case CoverType.SolidPaperEdged:
					coverType = "Суцільно паперова, тверда з кантом";
					break;
				case CoverType.SolidFabricSoftEdged:
					coverType = "Суцільно тканинна, м’яка з кантом";
					break;
				case CoverType.SolidFabricEdged:
					coverType = "Суцільно тканинна, тверда з кантом";
					break;
				case CoverType.ComponentEdged:
					coverType = "Складова, тверда з кантом";
					break;
				case CoverType.PlasticSoft:
					coverType = "Пластмасова м’яка";
					break;
				case CoverType.PlasticSemiRigid:
					coverType = "Пластмасова, напівжорстка";
					break;
				case CoverType.PlasticHard:
					coverType = "Пластмасова, жорстка";
					break;
			}

			return coverType;
		}
		private string GetBindingTypeString()
		{
			string bindingType = "";
			//повертаємо тип переплетення в залежності від того, який обраний:
			switch (book.BindingType)
			{
				case BindingType.Binding7BC:
					bindingType = "Переплетення 7БЦ (целофанованове)";
					break;
				case BindingType.Binding7B:
					bindingType = "Переплетення 7Б";
					break;
				case BindingType.IntegralBinding:
					bindingType = "Інтегральне переплетення";
					break;
				case BindingType.FrenchBinding:
					bindingType = "Французьке переплетення";
					break;
				case BindingType.WireOBinding:
					bindingType = "Wire-O переплетення";
					break;
				case BindingType.GlueSeamless:
					bindingType = "Клейове безшовне з'єднання";
					break;
				case BindingType.Stapling:
					bindingType = "Скобкове з'єднання";
					break;
				case BindingType.PaperLacing:
					bindingType = "Зшивання";
					break;
				case BindingType.Stitching:
					bindingType = "Брошурування";
					break;
			}

			return bindingType;
		}
		private string GetPaperTypeName()
		{
			string type = "";
			switch (book.PaperType.Name)
			{
				case PaperLightReflectionType.Glossy:
					type = "Глянцевий папір";
					break;
				case PaperLightReflectionType.Matte:
					type = "Матовий папір";
					break;
			}

			return type;
		}
		private string GetGenreAmountLabel()
		{
			string genreAmount = "";
			//Перевіряємо, який жанр має книгa, в залежності від цього віддаємо потрібний рядок (лейбл):
			switch (book.Genre.Name)
			{
				case "Антологія":
					genreAmount = "Кількість творів:";
					break;
				case "Атлас":
					genreAmount = "Кількість карт:";
					break;
				case "Каталог":
					genreAmount = "Кількість товарів:";
					break;
				case "П'єса":
					genreAmount = "Кількість актів:";
					break;
				case "Довідник":
					genreAmount = "Кількість записів:";
					break;
				case "Роман":
					genreAmount = "Кількість глав:";
					break;
				case "Поема":
					genreAmount = "Кількість віршів:";
					break;
				case "Збірник задач":
					genreAmount = "Кількість задач:";
					break;
				case "Підручник":
					genreAmount = "Кількість параграфів:";
					break;
			}

			return genreAmount;
		}
		private void FillAllLabels()
		{
			//Заповнюємо усі рядки із параметрів отриманої книги:
			bookTypeLabel.Text = book.Type;
			bookAuthorLabel.Text = book.Author;
			bookNameLabel.Text = book.Name;
			bookYearLabel.Text = $"{book.Year} p.";
			coverTypeLabel.Text = GetCoverTypeString();
			BindingTypeLabel.Text = GetBindingTypeString();
			genreLabel.Text = book.Genre.Name;
			genreAmountLabel.Text = GetGenreAmountLabel();
			genreAmountNumberLabel.Text = book.Genre.GetAmount().ToString();
			genreInfoTextBox.Text = book.Genre.GetInfo();
			lengthLabel.Text = $"{book.BookSize.Length} мм";
			widthLabel.Text = $"{book.BookSize.Width} мм";
			heightLabel.Text = $"{book.BookSize.Height} мм";
			weightLabel.Text = $"{book.Weight} гр.";
			paperTypeLabel.Text = GetPaperTypeName();
			paperWhitenessLabel.Text = $"{book.PaperType.Whiteness} %";
			paperDensityLabel.Text = $"{book.PaperType.Density} гр./м.кв.";
		}

		private void OkButton_Click(object sender, EventArgs e)
		{
			Dispose();
		}
	}
}
