namespace Курсова
{
	partial class AddNewBookForm1
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.authorTextBox = new System.Windows.Forms.TextBox();
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.yearTextBox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.typeComboBox = new System.Windows.Forms.ComboBox();
			this.AddNewButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.DarkCyan;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(309, 69);
			this.label1.TabIndex = 0;
			this.label1.Text = "Крок 1 із 5.\r\nВкажіть основну інформацію:\r\n\r\n";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(13, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 19);
			this.label2.TabIndex = 1;
			this.label2.Text = "Автор:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 121);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(118, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "Назва книги:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(13, 167);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(112, 19);
			this.label4.TabIndex = 3;
			this.label4.Text = "Рік випуску:";
			// 
			// authorTextBox
			// 
			this.authorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.authorTextBox.Location = new System.Drawing.Point(154, 78);
			this.authorTextBox.Name = "authorTextBox";
			this.authorTextBox.Size = new System.Drawing.Size(225, 22);
			this.authorTextBox.TabIndex = 4;
			// 
			// nameTextBox
			// 
			this.nameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nameTextBox.Location = new System.Drawing.Point(154, 121);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(225, 22);
			this.nameTextBox.TabIndex = 5;
			// 
			// yearTextBox
			// 
			this.yearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.yearTextBox.Location = new System.Drawing.Point(154, 167);
			this.yearTextBox.Name = "yearTextBox";
			this.yearTextBox.Size = new System.Drawing.Size(35, 22);
			this.yearTextBox.TabIndex = 6;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(13, 211);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 19);
			this.label5.TabIndex = 7;
			this.label5.Text = "Тип книги:";
			// 
			// typeComboBox
			// 
			this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.typeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.typeComboBox.FormattingEnabled = true;
			this.typeComboBox.Items.AddRange(new object[] {
            "Художня книга",
            "Навчальна книга",
            "Спеціальна книга"});
			this.typeComboBox.Location = new System.Drawing.Point(154, 211);
			this.typeComboBox.Name = "typeComboBox";
			this.typeComboBox.Size = new System.Drawing.Size(150, 24);
			this.typeComboBox.TabIndex = 8;
			// 
			// AddNewButton
			// 
			this.AddNewButton.BackColor = System.Drawing.Color.Transparent;
			this.AddNewButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.AddNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AddNewButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AddNewButton.ForeColor = System.Drawing.Color.DarkCyan;
			this.AddNewButton.Location = new System.Drawing.Point(397, 243);
			this.AddNewButton.Name = "AddNewButton";
			this.AddNewButton.Size = new System.Drawing.Size(75, 30);
			this.AddNewButton.TabIndex = 9;
			this.AddNewButton.Text = "Далі";
			this.AddNewButton.UseVisualStyleBackColor = false;
			this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
			// 
			// AddNewBookForm1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 286);
			this.Controls.Add(this.AddNewButton);
			this.Controls.Add(this.typeComboBox);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.yearTextBox);
			this.Controls.Add(this.nameTextBox);
			this.Controls.Add(this.authorTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(500, 325);
			this.MinimumSize = new System.Drawing.Size(500, 325);
			this.Name = "AddNewBookForm1";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Додати книгу:";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox authorTextBox;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox yearTextBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox typeComboBox;
		private System.Windows.Forms.Button AddNewButton;
	}
}