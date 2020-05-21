namespace Курсова
{
	partial class AddNewBookForm2
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
			this.AddNewButton = new System.Windows.Forms.Button();
			this.amountLabel = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.genreComboBox = new System.Windows.Forms.ComboBox();
			this.amountTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// AddNewButton
			// 
			this.AddNewButton.BackColor = System.Drawing.Color.Transparent;
			this.AddNewButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.AddNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AddNewButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AddNewButton.ForeColor = System.Drawing.Color.DarkCyan;
			this.AddNewButton.Location = new System.Drawing.Point(397, 169);
			this.AddNewButton.Name = "AddNewButton";
			this.AddNewButton.Size = new System.Drawing.Size(75, 30);
			this.AddNewButton.TabIndex = 19;
			this.AddNewButton.Text = "Далі";
			this.AddNewButton.UseVisualStyleBackColor = false;
			this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
			// 
			// amountLabel
			// 
			this.amountLabel.AutoSize = true;
			this.amountLabel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.amountLabel.Location = new System.Drawing.Point(12, 123);
			this.amountLabel.Name = "amountLabel";
			this.amountLabel.Size = new System.Drawing.Size(189, 19);
			this.amountLabel.TabIndex = 12;
			this.amountLabel.Text = "Кількість чогось-там:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(13, 80);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 19);
			this.label2.TabIndex = 11;
			this.label2.Text = "Жанр:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.DarkCyan;
			this.label1.Location = new System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(154, 69);
			this.label1.TabIndex = 10;
			this.label1.Text = "Крок 2 із 5.\r\nВкажіть жанр:\r\n\r\n";
			// 
			// genreComboBox
			// 
			this.genreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.genreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.genreComboBox.FormattingEnabled = true;
			this.genreComboBox.Items.AddRange(new object[] {
            "Антологія",
            "Атлас",
            "Довідник",
            "Збірник задач",
            "Каталог",
            "Підручник",
            "Поема",
            "П\'єса",
            "Роман"});
			this.genreComboBox.Location = new System.Drawing.Point(81, 80);
			this.genreComboBox.Name = "genreComboBox";
			this.genreComboBox.Size = new System.Drawing.Size(155, 24);
			this.genreComboBox.TabIndex = 20;
			this.genreComboBox.SelectedIndexChanged += new System.EventHandler(this.genreComboBox_SelectedIndexChanged);
			// 
			// amountTextBox
			// 
			this.amountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.amountTextBox.Location = new System.Drawing.Point(207, 123);
			this.amountTextBox.Name = "amountTextBox";
			this.amountTextBox.Size = new System.Drawing.Size(103, 22);
			this.amountTextBox.TabIndex = 21;
			// 
			// AddNewBookForm2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 211);
			this.Controls.Add(this.amountTextBox);
			this.Controls.Add(this.genreComboBox);
			this.Controls.Add(this.AddNewButton);
			this.Controls.Add(this.amountLabel);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(500, 250);
			this.MinimumSize = new System.Drawing.Size(500, 250);
			this.Name = "AddNewBookForm2";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Додати книгу:";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AddNewButton;
		private System.Windows.Forms.Label amountLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox genreComboBox;
		private System.Windows.Forms.TextBox amountTextBox;
	}
}