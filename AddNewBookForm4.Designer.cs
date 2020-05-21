namespace Курсова
{
	partial class AddNewBookForm4
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
			this.lightReflectionComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.AddNewButton = new System.Windows.Forms.Button();
			this.whitenessTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.densityTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// lightReflectionComboBox
			// 
			this.lightReflectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.lightReflectionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lightReflectionComboBox.FormattingEnabled = true;
			this.lightReflectionComboBox.Items.AddRange(new object[] {
            "Глянцевий папір",
            "Матовий папір"});
			this.lightReflectionComboBox.Location = new System.Drawing.Point(227, 170);
			this.lightReflectionComboBox.Name = "lightReflectionComboBox";
			this.lightReflectionComboBox.Size = new System.Drawing.Size(170, 24);
			this.lightReflectionComboBox.TabIndex = 31;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 170);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(209, 19);
			this.label3.TabIndex = 30;
			this.label3.Text = "Глянцевість/Матовість:";
			// 
			// AddNewButton
			// 
			this.AddNewButton.BackColor = System.Drawing.Color.Transparent;
			this.AddNewButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.AddNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AddNewButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AddNewButton.ForeColor = System.Drawing.Color.DarkCyan;
			this.AddNewButton.Location = new System.Drawing.Point(397, 245);
			this.AddNewButton.Name = "AddNewButton";
			this.AddNewButton.Size = new System.Drawing.Size(75, 30);
			this.AddNewButton.TabIndex = 28;
			this.AddNewButton.Text = "Далі";
			this.AddNewButton.UseVisualStyleBackColor = false;
			this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
			// 
			// whitenessTextBox
			// 
			this.whitenessTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.whitenessTextBox.Location = new System.Drawing.Point(126, 80);
			this.whitenessTextBox.Name = "whitenessTextBox";
			this.whitenessTextBox.Size = new System.Drawing.Size(44, 22);
			this.whitenessTextBox.TabIndex = 27;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(108, 19);
			this.label4.TabIndex = 26;
			this.label4.Text = "Білизна, %:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 124);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(167, 19);
			this.label2.TabIndex = 25;
			this.label2.Text = "Щільність, г/м.кв.:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.DarkCyan;
			this.label1.Location = new System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(253, 46);
			this.label1.TabIndex = 24;
			this.label1.Text = "Крок 4 із 5.\r\nВкажіть формат паперу:\r\n";
			// 
			// densityTextBox
			// 
			this.densityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.densityTextBox.Location = new System.Drawing.Point(185, 124);
			this.densityTextBox.Name = "densityTextBox";
			this.densityTextBox.Size = new System.Drawing.Size(44, 22);
			this.densityTextBox.TabIndex = 32;
			// 
			// AddNewBookForm4
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 286);
			this.Controls.Add(this.densityTextBox);
			this.Controls.Add(this.lightReflectionComboBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.AddNewButton);
			this.Controls.Add(this.whitenessTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(500, 325);
			this.MinimumSize = new System.Drawing.Size(500, 325);
			this.Name = "AddNewBookForm4";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Додати книгу:";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox lightReflectionComboBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button AddNewButton;
		private System.Windows.Forms.TextBox whitenessTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox densityTextBox;
	}
}