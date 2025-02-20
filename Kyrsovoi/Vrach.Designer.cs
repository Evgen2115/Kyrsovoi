
namespace Kyrsovoi
{
    partial class Vrach
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Otch = new System.Windows.Forms.TextBox();
            this.textBox_Fam = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.Врач = new System.Windows.Forms.LinkLabel();
            this.Назад = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(776, 261);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_Otch);
            this.panel1.Controls.Add(this.textBox_Fam);
            this.panel1.Controls.Add(this.textBox_Name);
            this.panel1.Controls.Add(this.textBox_ID);
            this.panel1.Location = new System.Drawing.Point(841, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 186);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Отчество";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // textBox_Otch
            // 
            this.textBox_Otch.Location = new System.Drawing.Point(137, 100);
            this.textBox_Otch.Name = "textBox_Otch";
            this.textBox_Otch.Size = new System.Drawing.Size(167, 22);
            this.textBox_Otch.TabIndex = 3;
            // 
            // textBox_Fam
            // 
            this.textBox_Fam.Location = new System.Drawing.Point(137, 73);
            this.textBox_Fam.Name = "textBox_Fam";
            this.textBox_Fam.Size = new System.Drawing.Size(167, 22);
            this.textBox_Fam.TabIndex = 2;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(137, 45);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(167, 22);
            this.textBox_Name.TabIndex = 1;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(137, 15);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(167, 22);
            this.textBox_ID.TabIndex = 0;
            // 
            // Врач
            // 
            this.Врач.Location = new System.Drawing.Point(367, 9);
            this.Врач.Name = "Врач";
            this.Врач.Size = new System.Drawing.Size(136, 37);
            this.Врач.TabIndex = 8;
            this.Врач.TabStop = true;
            this.Врач.Text = "Врач";
            this.Врач.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Назад
            // 
            this.Назад.Location = new System.Drawing.Point(1171, 9);
            this.Назад.Name = "Назад";
            this.Назад.Size = new System.Drawing.Size(94, 33);
            this.Назад.TabIndex = 9;
            this.Назад.Text = "Назад";
            this.Назад.UseVisualStyleBackColor = true;
            this.Назад.Click += new System.EventHandler(this.Назад_Click);
            // 
            // Vrach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1277, 450);
            this.Controls.Add(this.Назад);
            this.Controls.Add(this.Врач);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Vrach";
            this.Text = "Vrach";
            this.Load += new System.EventHandler(this.Vrach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Otch;
        private System.Windows.Forms.TextBox textBox_Fam;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.LinkLabel Врач;
        private System.Windows.Forms.Button Назад;
    }
}