namespace Курсова
{
	partial class MenuForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.ShowAllButton = new System.Windows.Forms.Button();
			this.AddNewButton = new System.Windows.Forms.Button();
			this.ExitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.DarkCyan;
			this.label1.Location = new System.Drawing.Point(70, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(136, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Оберіть дію:";
			// 
			// ShowAllButton
			// 
			this.ShowAllButton.BackColor = System.Drawing.Color.Transparent;
			this.ShowAllButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.ShowAllButton.FlatAppearance.BorderSize = 0;
			this.ShowAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ShowAllButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ShowAllButton.Location = new System.Drawing.Point(39, 55);
			this.ShowAllButton.Name = "ShowAllButton";
			this.ShowAllButton.Size = new System.Drawing.Size(202, 43);
			this.ShowAllButton.TabIndex = 1;
			this.ShowAllButton.Text = "Переглянути усі записи";
			this.ShowAllButton.UseVisualStyleBackColor = false;
			this.ShowAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
			// 
			// AddNewButton
			// 
			this.AddNewButton.BackColor = System.Drawing.Color.Transparent;
			this.AddNewButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.AddNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AddNewButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AddNewButton.Location = new System.Drawing.Point(39, 124);
			this.AddNewButton.Name = "AddNewButton";
			this.AddNewButton.Size = new System.Drawing.Size(202, 43);
			this.AddNewButton.TabIndex = 2;
			this.AddNewButton.Text = "Додати новий запис";
			this.AddNewButton.UseVisualStyleBackColor = false;
			this.AddNewButton.Click += new System.EventHandler(this.AddNewButton_Click);
			// 
			// ExitButton
			// 
			this.ExitButton.BackColor = System.Drawing.Color.Transparent;
			this.ExitButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
			this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.ExitButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.ExitButton.Location = new System.Drawing.Point(39, 195);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(202, 43);
			this.ExitButton.TabIndex = 3;
			this.ExitButton.Text = "Вийти із додатку";
			this.ExitButton.UseVisualStyleBackColor = false;
			this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
			// 
			// MenuForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(274, 271);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.AddNewButton);
			this.Controls.Add(this.ShowAllButton);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(290, 310);
			this.MinimumSize = new System.Drawing.Size(290, 310);
			this.Name = "MenuForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Система обліку книг";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button AddNewButton;
		private System.Windows.Forms.Button ExitButton;
		private System.Windows.Forms.Button ShowAllButton;
	}
}

