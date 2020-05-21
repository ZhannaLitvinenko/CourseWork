namespace Курсова
{
	partial class ShowAllBooksForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.booksListView = new System.Windows.Forms.ListView();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.deleteButton = new System.Windows.Forms.Button();
			this.showBookButton = new System.Windows.Forms.Button();
			this.bookTypeLabel = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.yearLabel = new System.Windows.Forms.Label();
			this.genreLabel = new System.Windows.Forms.Label();
			this.nameLabel = new System.Windows.Forms.Label();
			this.authorLabel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// booksListView
			// 
			this.booksListView.BackColor = System.Drawing.SystemColors.Menu;
			this.booksListView.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.booksListView.HideSelection = false;
			this.booksListView.Location = new System.Drawing.Point(16, 50);
			this.booksListView.Name = "booksListView";
			this.booksListView.Size = new System.Drawing.Size(391, 399);
			this.booksListView.TabIndex = 0;
			this.booksListView.TileSize = new System.Drawing.Size(350, 40);
			this.booksListView.UseCompatibleStateImageBehavior = false;
			this.booksListView.SelectedIndexChanged += new System.EventHandler(this.booksListView_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.DarkCyan;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(198, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Усі записані книги:";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Gainsboro;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.deleteButton);
			this.panel1.Controls.Add(this.showBookButton);
			this.panel1.Controls.Add(this.bookTypeLabel);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.yearLabel);
			this.panel1.Controls.Add(this.genreLabel);
			this.panel1.Controls.Add(this.nameLabel);
			this.panel1.Controls.Add(this.authorLabel);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(431, 21);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(291, 428);
			this.panel1.TabIndex = 2;
			// 
			// deleteButton
			// 
			this.deleteButton.BackColor = System.Drawing.Color.Transparent;
			this.deleteButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.deleteButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.deleteButton.ForeColor = System.Drawing.Color.Firebrick;
			this.deleteButton.Location = new System.Drawing.Point(178, 324);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(103, 44);
			this.deleteButton.TabIndex = 39;
			this.deleteButton.Text = "Видалити";
			this.deleteButton.UseVisualStyleBackColor = false;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// showBookButton
			// 
			this.showBookButton.BackColor = System.Drawing.Color.Transparent;
			this.showBookButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.showBookButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.showBookButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.showBookButton.ForeColor = System.Drawing.Color.DarkCyan;
			this.showBookButton.Location = new System.Drawing.Point(164, 374);
			this.showBookButton.Name = "showBookButton";
			this.showBookButton.Size = new System.Drawing.Size(117, 44);
			this.showBookButton.TabIndex = 38;
			this.showBookButton.Text = "Переглянути";
			this.showBookButton.UseVisualStyleBackColor = false;
			this.showBookButton.Click += new System.EventHandler(this.showBookButton_Click);
			// 
			// bookTypeLabel
			// 
			this.bookTypeLabel.AutoSize = true;
			this.bookTypeLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bookTypeLabel.ForeColor = System.Drawing.SystemColors.InfoText;
			this.bookTypeLabel.Location = new System.Drawing.Point(18, 74);
			this.bookTypeLabel.Name = "bookTypeLabel";
			this.bookTypeLabel.Size = new System.Drawing.Size(38, 23);
			this.bookTypeLabel.TabIndex = 12;
			this.bookTypeLabel.Text = "----";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.ForeColor = System.Drawing.Color.DarkCyan;
			this.label11.Location = new System.Drawing.Point(3, 43);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(115, 23);
			this.label11.TabIndex = 11;
			this.label11.Text = "Тип книги:";
			// 
			// yearLabel
			// 
			this.yearLabel.AutoSize = true;
			this.yearLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.yearLabel.ForeColor = System.Drawing.SystemColors.InfoText;
			this.yearLabel.Location = new System.Drawing.Point(18, 343);
			this.yearLabel.Name = "yearLabel";
			this.yearLabel.Size = new System.Drawing.Size(38, 23);
			this.yearLabel.TabIndex = 10;
			this.yearLabel.Text = "----";
			// 
			// genreLabel
			// 
			this.genreLabel.AutoSize = true;
			this.genreLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.genreLabel.ForeColor = System.Drawing.SystemColors.InfoText;
			this.genreLabel.Location = new System.Drawing.Point(18, 270);
			this.genreLabel.Name = "genreLabel";
			this.genreLabel.Size = new System.Drawing.Size(38, 23);
			this.genreLabel.TabIndex = 9;
			this.genreLabel.Text = "----";
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nameLabel.ForeColor = System.Drawing.SystemColors.InfoText;
			this.nameLabel.Location = new System.Drawing.Point(18, 202);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(38, 23);
			this.nameLabel.TabIndex = 8;
			this.nameLabel.Text = "----";
			// 
			// authorLabel
			// 
			this.authorLabel.AutoSize = true;
			this.authorLabel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.authorLabel.ForeColor = System.Drawing.SystemColors.InfoText;
			this.authorLabel.Location = new System.Drawing.Point(18, 131);
			this.authorLabel.Name = "authorLabel";
			this.authorLabel.Size = new System.Drawing.Size(38, 23);
			this.authorLabel.TabIndex = 7;
			this.authorLabel.Text = "----";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.ForeColor = System.Drawing.Color.DarkCyan;
			this.label6.Location = new System.Drawing.Point(3, 310);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(131, 23);
			this.label6.TabIndex = 6;
			this.label6.Text = "Рік випуску:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.Color.DarkCyan;
			this.label5.Location = new System.Drawing.Point(3, 239);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 23);
			this.label5.TabIndex = 5;
			this.label5.Text = "Жанр:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.DarkCyan;
			this.label4.Location = new System.Drawing.Point(3, 171);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(76, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "Назва:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.DarkCyan;
			this.label2.Location = new System.Drawing.Point(3, 102);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Автор:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.SystemColors.InfoText;
			this.label3.Location = new System.Drawing.Point(161, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(130, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "Обрана книга";
			// 
			// ShowAllBooksForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(734, 461);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.booksListView);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(750, 500);
			this.MinimumSize = new System.Drawing.Size(750, 500);
			this.Name = "ShowAllBooksForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "ShowAllBooksForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView booksListView;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label genreLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.Label authorLabel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label bookTypeLabel;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label yearLabel;
		private System.Windows.Forms.Button showBookButton;
		private System.Windows.Forms.Button deleteButton;
	}
}