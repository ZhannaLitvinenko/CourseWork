namespace Курсова
{
	partial class AddNewBookForm5
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
			this.CreateButton = new System.Windows.Forms.Button();
			this.lengthTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.widthTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.heightTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// CreateButton
			// 
			this.CreateButton.BackColor = System.Drawing.Color.Transparent;
			this.CreateButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.CreateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.CreateButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CreateButton.ForeColor = System.Drawing.Color.DarkCyan;
			this.CreateButton.Location = new System.Drawing.Point(372, 169);
			this.CreateButton.Name = "CreateButton";
			this.CreateButton.Size = new System.Drawing.Size(100, 30);
			this.CreateButton.TabIndex = 37;
			this.CreateButton.Text = "Створити";
			this.CreateButton.UseVisualStyleBackColor = false;
			this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
			// 
			// lengthTextBox
			// 
			this.lengthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lengthTextBox.Location = new System.Drawing.Point(144, 80);
			this.lengthTextBox.Name = "lengthTextBox";
			this.lengthTextBox.Size = new System.Drawing.Size(44, 22);
			this.lengthTextBox.TabIndex = 36;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(126, 19);
			this.label4.TabIndex = 35;
			this.label4.Text = "Довжина, мм:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.DarkCyan;
			this.label1.Location = new System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(242, 46);
			this.label1.TabIndex = 33;
			this.label1.Text = "Крок 5 із 5.\r\nВкажіть розміри книги:";
			// 
			// widthTextBox
			// 
			this.widthTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.widthTextBox.Location = new System.Drawing.Point(144, 120);
			this.widthTextBox.Name = "widthTextBox";
			this.widthTextBox.Size = new System.Drawing.Size(44, 22);
			this.widthTextBox.TabIndex = 39;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(116, 19);
			this.label2.TabIndex = 38;
			this.label2.Text = "Ширина, мм:";
			// 
			// heightTextBox
			// 
			this.heightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.heightTextBox.Location = new System.Drawing.Point(144, 160);
			this.heightTextBox.Name = "heightTextBox";
			this.heightTextBox.Size = new System.Drawing.Size(44, 22);
			this.heightTextBox.TabIndex = 41;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 160);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 19);
			this.label3.TabIndex = 40;
			this.label3.Text = "Висота, мм:";
			// 
			// AddNewBookForm5
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 211);
			this.Controls.Add(this.heightTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.widthTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.CreateButton);
			this.Controls.Add(this.lengthTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(500, 250);
			this.MinimumSize = new System.Drawing.Size(500, 250);
			this.Name = "AddNewBookForm5";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Додати книгу:";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button CreateButton;
		private System.Windows.Forms.TextBox lengthTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox widthTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox heightTextBox;
		private System.Windows.Forms.Label label3;
	}
}