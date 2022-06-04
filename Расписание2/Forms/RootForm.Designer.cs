namespace Расписание2.Forms
{
	partial class RootForm
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.управлениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.кабинетамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.дисциплинамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.преподавателямиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.видToolStripMenuItem,
            this.управлениеToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(505, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// файлToolStripMenuItem
			// 
			this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
			this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.файлToolStripMenuItem.Text = "Файл";
			// 
			// правкаToolStripMenuItem
			// 
			this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
			this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
			this.правкаToolStripMenuItem.Text = "Правка";
			// 
			// видToolStripMenuItem
			// 
			this.видToolStripMenuItem.Name = "видToolStripMenuItem";
			this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
			this.видToolStripMenuItem.Text = "Вид";
			// 
			// управлениеToolStripMenuItem
			// 
			this.управлениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.кабинетамиToolStripMenuItem,
            this.дисциплинамиToolStripMenuItem,
            this.преподавателямиToolStripMenuItem});
			this.управлениеToolStripMenuItem.Name = "управлениеToolStripMenuItem";
			this.управлениеToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
			this.управлениеToolStripMenuItem.Text = "Управление";
			// 
			// кабинетамиToolStripMenuItem
			// 
			this.кабинетамиToolStripMenuItem.Name = "кабинетамиToolStripMenuItem";
			this.кабинетамиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.кабинетамиToolStripMenuItem.Text = "Кабинетами";
			this.кабинетамиToolStripMenuItem.Click += new System.EventHandler(this.кабинетамиToolStripMenuItem_Click);
			// 
			// дисциплинамиToolStripMenuItem
			// 
			this.дисциплинамиToolStripMenuItem.Name = "дисциплинамиToolStripMenuItem";
			this.дисциплинамиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.дисциплинамиToolStripMenuItem.Text = "Дисциплинами";
			// 
			// преподавателямиToolStripMenuItem
			// 
			this.преподавателямиToolStripMenuItem.Name = "преподавателямиToolStripMenuItem";
			this.преподавателямиToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.преподавателямиToolStripMenuItem.Text = "Преподавателями";
			// 
			// RootForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(505, 484);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "RootForm";
			this.Text = "RootForm";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private MenuStrip menuStrip1;
		private ToolStripMenuItem файлToolStripMenuItem;
		private ToolStripMenuItem правкаToolStripMenuItem;
		private ToolStripMenuItem видToolStripMenuItem;
		private ToolStripMenuItem управлениеToolStripMenuItem;
		private ToolStripMenuItem кабинетамиToolStripMenuItem;
		private ToolStripMenuItem дисциплинамиToolStripMenuItem;
		private ToolStripMenuItem преподавателямиToolStripMenuItem;
	}
}