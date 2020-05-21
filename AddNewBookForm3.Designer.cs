namespace Курсова
{
	partial class AddNewBookForm3
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
			this.weightTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.coverTypeComboBox = new System.Windows.Forms.ComboBox();
			this.bindingTypeComboBox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
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
			this.AddNewButton.TabIndex = 19;
			this.AddNewButton.Text = "Далі";
			this.AddNewButton.UseVisualStyleBackColor = false;
			this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
			// 
			// weightTextBox
			// 
			this.weightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.weightTextBox.Location = new System.Drawing.Point(122, 78);
			this.weightTextBox.Name = "weightTextBox";
			this.weightTextBox.Size = new System.Drawing.Size(44, 22);
			this.weightTextBox.TabIndex = 16;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(12, 78);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(104, 19);
			this.label4.TabIndex = 13;
			this.label4.Text = "Вага, грам:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(12, 122);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(134, 19);
			this.label2.TabIndex = 11;
			this.label2.Text = "Тип палітурки:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.DarkCyan;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(331, 69);
			this.label1.TabIndex = 10;
			this.label1.Text = "Крок 3 із 5.\r\nВкажіть додаткову інформацію:\r\n\r\n";
			// 
			// coverTypeComboBox
			// 
			this.coverTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.coverTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.coverTypeComboBox.FormattingEnabled = true;
			this.coverTypeComboBox.Items.AddRange(new object[] {
            "Суцільно картонна, обрізна",
            "Суцільно картонна, м’яка з кантом",
            "Суцільно паперова, тверда з кантом",
            "Суцільно тканинна, м’яка з кантом",
            "Суцільно тканинна, тверда з кантом",
            "Складова, тверда з кантом",
            "Пластмасова м’яка",
            "Пластмасова, напівжорстка",
            "Пластмасова, жорстка"});
			this.coverTypeComboBox.Location = new System.Drawing.Point(152, 122);
			this.coverTypeComboBox.Name = "coverTypeComboBox";
			this.coverTypeComboBox.Size = new System.Drawing.Size(268, 24);
			this.coverTypeComboBox.TabIndex = 20;
			// 
			// bindingTypeComboBox
			// 
			this.bindingTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.bindingTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.bindingTypeComboBox.FormattingEnabled = true;
			this.bindingTypeComboBox.Items.AddRange(new object[] {
            "Переплетення 7БЦ (целофанованове)",
            "Переплетення 7Б",
            "Інтегральне переплетення",
            "Французьке переплетення",
            "Wire-O переплетення",
            "Клейове безшовне з\'єднання",
            "Скобкове з\'єднання",
            "Зшивання",
            "Брошурування"});
			this.bindingTypeComboBox.Location = new System.Drawing.Point(188, 168);
			this.bindingTypeComboBox.Name = "bindingTypeComboBox";
			this.bindingTypeComboBox.Size = new System.Drawing.Size(268, 24);
			this.bindingTypeComboBox.TabIndex = 23;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(12, 168);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(170, 19);
			this.label3.TabIndex = 22;
			this.label3.Text = "Тип переплетення:";
			// 
			// AddNewBookForm3
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(484, 286);
			this.Controls.Add(this.bindingTypeComboBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.coverTypeComboBox);
			this.Controls.Add(this.AddNewButton);
			this.Controls.Add(this.weightTextBox);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(500, 325);
			this.MinimumSize = new System.Drawing.Size(500, 325);
			this.Name = "AddNewBookForm3";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "AddNewBookForm3";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button AddNewButton;
		private System.Windows.Forms.TextBox weightTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox coverTypeComboBox;
		private System.Windows.Forms.ComboBox bindingTypeComboBox;
		private System.Windows.Forms.Label label3;
	}
}