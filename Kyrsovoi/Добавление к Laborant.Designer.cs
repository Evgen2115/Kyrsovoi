
namespace Kyrsovoi
{
    partial class Добавление_к_Laborant
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
            this.Save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Nazv2 = new System.Windows.Forms.TextBox();
            this.textBox_Fam2 = new System.Windows.Forms.TextBox();
            this.textBox_Name2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(349, 309);
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
            this.label4.Location = new System.Drawing.Point(163, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(474, 48);
            this.label4.TabIndex = 16;
            this.label4.Text = "Добавление записи: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.UseCompatibleTextRendering = true;
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(132, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Название диагноза";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Фамилия";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Имя";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_Nazv2
            // 
            this.textBox_Nazv2.Location = new System.Drawing.Point(274, 244);
            this.textBox_Nazv2.Name = "textBox_Nazv2";
            this.textBox_Nazv2.Size = new System.Drawing.Size(260, 22);
            this.textBox_Nazv2.TabIndex = 12;
            // 
            // textBox_Fam2
            // 
            this.textBox_Fam2.Location = new System.Drawing.Point(274, 196);
            this.textBox_Fam2.Name = "textBox_Fam2";
            this.textBox_Fam2.Size = new System.Drawing.Size(260, 22);
            this.textBox_Fam2.TabIndex = 11;
            // 
            // textBox_Name2
            // 
            this.textBox_Name2.Location = new System.Drawing.Point(274, 156);
            this.textBox_Name2.Name = "textBox_Name2";
            this.textBox_Name2.Size = new System.Drawing.Size(260, 22);
            this.textBox_Name2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Добавление_к_Laborant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_Nazv2);
            this.Controls.Add(this.textBox_Fam2);
            this.Controls.Add(this.textBox_Name2);
            this.Name = "Добавление_к_Laborant";
            this.Text = "Добавление_к_Laborant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Save;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Nazv2;
        private System.Windows.Forms.TextBox textBox_Fam2;
        private System.Windows.Forms.TextBox textBox_Name2;
        private System.Windows.Forms.Button button1;
    }
}