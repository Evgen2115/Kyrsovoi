
namespace Kyrsovoi
{
    partial class Добавление_записи_к_Posetitel
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
            this.label5 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Otch3 = new System.Windows.Forms.TextBox();
            this.textBox_Fam3 = new System.Windows.Forms.TextBox();
            this.textBox_Name3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DATE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Год рождения";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(462, 339);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(112, 36);
            this.Save.TabIndex = 17;
            this.Save.Text = "Сохранить";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.label4.Font = new System.Drawing.Font("Microsoft Yi Baiti", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(282, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(474, 48);
            this.label4.TabIndex = 16;
            this.label4.Text = "Добавление записи: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseCompatibleTextRendering = true;
            this.label4.UseWaitCursor = true;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Отчество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(352, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Имя";
            // 
            // textBox_Otch3
            // 
            this.textBox_Otch3.Location = new System.Drawing.Point(393, 246);
            this.textBox_Otch3.Name = "textBox_Otch3";
            this.textBox_Otch3.Size = new System.Drawing.Size(260, 22);
            this.textBox_Otch3.TabIndex = 12;
            // 
            // textBox_Fam3
            // 
            this.textBox_Fam3.Location = new System.Drawing.Point(393, 198);
            this.textBox_Fam3.Name = "textBox_Fam3";
            this.textBox_Fam3.Size = new System.Drawing.Size(260, 22);
            this.textBox_Fam3.TabIndex = 11;
            // 
            // textBox_Name3
            // 
            this.textBox_Name3.Location = new System.Drawing.Point(393, 158);
            this.textBox_Name3.Name = "textBox_Name3";
            this.textBox_Name3.Size = new System.Drawing.Size(260, 22);
            this.textBox_Name3.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 21;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DATE
            // 
            this.DATE.Location = new System.Drawing.Point(393, 293);
            this.DATE.Name = "DATE";
            this.DATE.Size = new System.Drawing.Size(260, 22);
            this.DATE.TabIndex = 22;
            // 
            // Добавление_записи_к_Posetitel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1038, 454);
            this.Controls.Add(this.DATE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Otch3);
            this.Controls.Add(this.textBox_Fam3);
            this.Controls.Add(this.textBox_Name3);
            this.Name = "Добавление_записи_к_Posetitel";
            this.Text = "Добавление_записи_к_Posetitel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Save;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Otch3;
        private System.Windows.Forms.TextBox textBox_Fam3;
        private System.Windows.Forms.TextBox textBox_Name3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox DATE;
    }
}