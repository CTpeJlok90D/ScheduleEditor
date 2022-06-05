namespace Расписание2.Forms
{
	partial class ClassRoomsManager
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
			this.classRooms_ListBox = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.name_TextBox = new System.Windows.Forms.TextBox();
			this.descriprion_RichTextBox = new System.Windows.Forms.RichTextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.classRoomType_comboBox = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.classRoomTypeControl_button = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Add_Button = new System.Windows.Forms.Button();
			this.Delete_Button = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// classRooms_ListBox
			// 
			this.classRooms_ListBox.FormattingEnabled = true;
			this.classRooms_ListBox.ItemHeight = 15;
			this.classRooms_ListBox.Location = new System.Drawing.Point(17, 30);
			this.classRooms_ListBox.Name = "classRooms_ListBox";
			this.classRooms_ListBox.Size = new System.Drawing.Size(172, 274);
			this.classRooms_ListBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(17, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(64, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Кабинеты:";
			// 
			// name_TextBox
			// 
			this.name_TextBox.Location = new System.Drawing.Point(9, 26);
			this.name_TextBox.Name = "name_TextBox";
			this.name_TextBox.Size = new System.Drawing.Size(147, 23);
			this.name_TextBox.TabIndex = 2;
			// 
			// descriprion_RichTextBox
			// 
			this.descriprion_RichTextBox.Location = new System.Drawing.Point(9, 70);
			this.descriprion_RichTextBox.Name = "descriprion_RichTextBox";
			this.descriprion_RichTextBox.Size = new System.Drawing.Size(147, 96);
			this.descriprion_RichTextBox.TabIndex = 3;
			this.descriprion_RichTextBox.Text = "";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(9, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(84, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Имя кабинета";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(9, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(115, 15);
			this.label3.TabIndex = 5;
			this.label3.Text = "Описание кабинета";
			// 
			// classRoomType_comboBox
			// 
			this.classRoomType_comboBox.FormattingEnabled = true;
			this.classRoomType_comboBox.Location = new System.Drawing.Point(9, 27);
			this.classRoomType_comboBox.Name = "classRoomType_comboBox";
			this.classRoomType_comboBox.Size = new System.Drawing.Size(147, 23);
			this.classRoomType_comboBox.TabIndex = 6;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "Тип кабинета";
			// 
			// classRoomTypeControl_button
			// 
			this.classRoomTypeControl_button.Location = new System.Drawing.Point(9, 56);
			this.classRoomTypeControl_button.Name = "classRoomTypeControl_button";
			this.classRoomTypeControl_button.Size = new System.Drawing.Size(147, 23);
			this.classRoomTypeControl_button.TabIndex = 8;
			this.classRoomTypeControl_button.Text = "Управление типами";
			this.classRoomTypeControl_button.UseVisualStyleBackColor = true;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.descriprion_RichTextBox);
			this.panel1.Controls.Add(this.name_TextBox);
			this.panel1.Location = new System.Drawing.Point(207, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(161, 179);
			this.panel1.TabIndex = 9;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.classRoomType_comboBox);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.classRoomTypeControl_button);
			this.panel2.Location = new System.Drawing.Point(207, 212);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(161, 92);
			this.panel2.TabIndex = 10;
			// 
			// Add_Button
			// 
			this.Add_Button.Location = new System.Drawing.Point(17, 310);
			this.Add_Button.Name = "Add_Button";
			this.Add_Button.Size = new System.Drawing.Size(75, 23);
			this.Add_Button.TabIndex = 11;
			this.Add_Button.Text = "Добавить";
			this.Add_Button.UseVisualStyleBackColor = true;
			// 
			// Delete_Button
			// 
			this.Delete_Button.Location = new System.Drawing.Point(114, 310);
			this.Delete_Button.Name = "Delete_Button";
			this.Delete_Button.Size = new System.Drawing.Size(75, 23);
			this.Delete_Button.TabIndex = 12;
			this.Delete_Button.Text = "Удалить";
			this.Delete_Button.UseVisualStyleBackColor = true;
			// 
			// ClassRoomsManager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(392, 351);
			this.Controls.Add(this.Delete_Button);
			this.Controls.Add(this.Add_Button);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.classRooms_ListBox);
			this.Name = "ClassRoomsManager";
			this.Text = "Управление аудиториями";
			this.Load += new System.EventHandler(this.ClassRoomsManager_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ListBox classRooms_ListBox;
		private Label label1;
		private TextBox name_TextBox;
		private RichTextBox descriprion_RichTextBox;
		private Label label2;
		private Label label3;
		private ComboBox classRoomType_comboBox;
		private Label label4;
		private Button classRoomTypeControl_button;
		private Panel panel1;
		private Panel panel2;
		private Button Add_Button;
		private Button Delete_Button;
	}
}