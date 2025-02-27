
namespace Kyrsovoi
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_lab2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_lab = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_vrem = new System.Windows.Forms.TextBox();
            this.textBox_date = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Refresh = new System.Windows.Forms.Button();
            this.Laborant = new System.Windows.Forms.Button();
            this.Lechenie = new System.Windows.Forms.Button();
            this.Posetitel = new System.Windows.Forms.Button();
            this.Vrach = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 261);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox_lab2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_lab);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_vrem);
            this.panel1.Controls.Add(this.textBox_date);
            this.panel1.Controls.Add(this.textBox_Name);
            this.panel1.Controls.Add(this.textBox_ID);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(698, 317);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(376, 200);
            this.panel1.TabIndex = 1;
            this.panel1.TabStop = true;
            this.panel1.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "ID_Посетителя";
            this.label6.UseWaitCursor = true;
            // 
            // textBox_lab2
            // 
            this.textBox_lab2.Location = new System.Drawing.Point(137, 161);
            this.textBox_lab2.Name = "textBox_lab2";
            this.textBox_lab2.Size = new System.Drawing.Size(167, 22);
            this.textBox_lab2.TabIndex = 11;
            this.textBox_lab2.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID_Лаборанта";
            this.label5.UseWaitCursor = true;
            // 
            // textBox_lab
            // 
            this.textBox_lab.Location = new System.Drawing.Point(137, 133);
            this.textBox_lab.Name = "textBox_lab";
            this.textBox_lab.Size = new System.Drawing.Size(167, 22);
            this.textBox_lab.TabIndex = 9;
            this.textBox_lab.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Время сдачи";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дата сдачи";
            this.label3.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Название";
            this.label2.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            this.label1.UseWaitCursor = true;
            // 
            // textBox_vrem
            // 
            this.textBox_vrem.Location = new System.Drawing.Point(137, 100);
            this.textBox_vrem.Name = "textBox_vrem";
            this.textBox_vrem.Size = new System.Drawing.Size(167, 22);
            this.textBox_vrem.TabIndex = 3;
            this.textBox_vrem.UseWaitCursor = true;
            // 
            // textBox_date
            // 
            this.textBox_date.Location = new System.Drawing.Point(137, 73);
            this.textBox_date.Name = "textBox_date";
            this.textBox_date.Size = new System.Drawing.Size(167, 22);
            this.textBox_date.TabIndex = 2;
            this.textBox_date.UseWaitCursor = true;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(137, 45);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(167, 22);
            this.textBox_Name.TabIndex = 1;
            this.textBox_Name.UseWaitCursor = true;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(137, 15);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(167, 22);
            this.textBox_ID.TabIndex = 0;
            this.textBox_ID.UseWaitCursor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(815, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 185);
            this.panel2.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(56, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(109, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 69);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 39);
            this.button2.TabIndex = 1;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(56, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить запись";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(12, 12);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(91, 35);
            this.Refresh.TabIndex = 3;
            this.Refresh.Text = "Обновить";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Laborant
            // 
            this.Laborant.Location = new System.Drawing.Point(36, 349);
            this.Laborant.Name = "Laborant";
            this.Laborant.Size = new System.Drawing.Size(112, 28);
            this.Laborant.TabIndex = 4;
            this.Laborant.Text = "Лаборант";
            this.Laborant.UseVisualStyleBackColor = true;
            this.Laborant.Click += new System.EventHandler(this.Laborant_Click);
            // 
            // Lechenie
            // 
            this.Lechenie.Location = new System.Drawing.Point(36, 397);
            this.Lechenie.Name = "Lechenie";
            this.Lechenie.Size = new System.Drawing.Size(112, 29);
            this.Lechenie.TabIndex = 5;
            this.Lechenie.Text = "Врач";
            this.Lechenie.UseVisualStyleBackColor = true;
            this.Lechenie.Click += new System.EventHandler(this.Lechenie_Click);
            // 
            // Posetitel
            // 
            this.Posetitel.Location = new System.Drawing.Point(210, 349);
            this.Posetitel.Name = "Posetitel";
            this.Posetitel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Posetitel.Size = new System.Drawing.Size(112, 29);
            this.Posetitel.TabIndex = 6;
            this.Posetitel.Text = "Посетитель";
            this.Posetitel.UseVisualStyleBackColor = true;
            this.Posetitel.Click += new System.EventHandler(this.Posetitel_Click);
            // 
            // Vrach
            // 
            this.Vrach.Location = new System.Drawing.Point(210, 397);
            this.Vrach.Name = "Vrach";
            this.Vrach.Size = new System.Drawing.Size(112, 29);
            this.Vrach.TabIndex = 7;
            this.Vrach.Text = "Лечение";
            this.Vrach.UseVisualStyleBackColor = true;
            this.Vrach.Click += new System.EventHandler(this.Vrach_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(343, 3);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(178, 44);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Анализы";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1086, 529);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Vrach);
            this.Controls.Add(this.Posetitel);
            this.Controls.Add(this.Lechenie);
            this.Controls.Add(this.Laborant);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.TransparencyKey = System.Drawing.Color.OldLace;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_vrem;
        private System.Windows.Forms.TextBox textBox_date;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_lab;
        private System.Windows.Forms.Button Laborant;
        private System.Windows.Forms.Button Lechenie;
        private System.Windows.Forms.Button Posetitel;
        private System.Windows.Forms.Button Vrach;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_lab2;
    }
}