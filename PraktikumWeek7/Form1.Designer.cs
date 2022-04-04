namespace PraktikumWeek7
{
    partial class FormQuizPanda
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
            this.LabelMasukkanNama = new System.Windows.Forms.Label();
            this.TextBoxNama = new System.Windows.Forms.TextBox();
            this.LabelMasukkanHuruf = new System.Windows.Forms.Label();
            this.TextBoxHuruf1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxHuruf2 = new System.Windows.Forms.TextBox();
            this.ButtonKonversi = new System.Windows.Forms.Button();
            this.LabelHasil = new System.Windows.Forms.Label();
            this.LabelOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelMasukkanNama
            // 
            this.LabelMasukkanNama.AutoSize = true;
            this.LabelMasukkanNama.Location = new System.Drawing.Point(42, 42);
            this.LabelMasukkanNama.Name = "LabelMasukkanNama";
            this.LabelMasukkanNama.Size = new System.Drawing.Size(118, 16);
            this.LabelMasukkanNama.TabIndex = 0;
            this.LabelMasukkanNama.Text = "Masukkan Nama : ";
            // 
            // TextBoxNama
            // 
            this.TextBoxNama.Location = new System.Drawing.Point(166, 42);
            this.TextBoxNama.Name = "TextBoxNama";
            this.TextBoxNama.Size = new System.Drawing.Size(369, 22);
            this.TextBoxNama.TabIndex = 1;
            // 
            // LabelMasukkanHuruf
            // 
            this.LabelMasukkanHuruf.AutoSize = true;
            this.LabelMasukkanHuruf.Location = new System.Drawing.Point(42, 75);
            this.LabelMasukkanHuruf.Name = "LabelMasukkanHuruf";
            this.LabelMasukkanHuruf.Size = new System.Drawing.Size(112, 16);
            this.LabelMasukkanHuruf.TabIndex = 2;
            this.LabelMasukkanHuruf.Text = "Masukkan Huruf : ";
            // 
            // TextBoxHuruf1
            // 
            this.TextBoxHuruf1.Location = new System.Drawing.Point(167, 73);
            this.TextBoxHuruf1.Name = "TextBoxHuruf1";
            this.TextBoxHuruf1.Size = new System.Drawing.Size(149, 22);
            this.TextBoxHuruf1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Menjadi : ";
            // 
            // TextBoxHuruf2
            // 
            this.TextBoxHuruf2.Location = new System.Drawing.Point(391, 75);
            this.TextBoxHuruf2.Name = "TextBoxHuruf2";
            this.TextBoxHuruf2.Size = new System.Drawing.Size(144, 22);
            this.TextBoxHuruf2.TabIndex = 5;
            // 
            // ButtonKonversi
            // 
            this.ButtonKonversi.Location = new System.Drawing.Point(225, 111);
            this.ButtonKonversi.Name = "ButtonKonversi";
            this.ButtonKonversi.Size = new System.Drawing.Size(113, 24);
            this.ButtonKonversi.TabIndex = 6;
            this.ButtonKonversi.Text = "Konversi";
            this.ButtonKonversi.UseVisualStyleBackColor = true;
            this.ButtonKonversi.Click += new System.EventHandler(this.ButtonKonversi_Click);
            // 
            // LabelHasil
            // 
            this.LabelHasil.AutoSize = true;
            this.LabelHasil.Location = new System.Drawing.Point(42, 142);
            this.LabelHasil.Name = "LabelHasil";
            this.LabelHasil.Size = new System.Drawing.Size(47, 16);
            this.LabelHasil.TabIndex = 7;
            this.LabelHasil.Text = "Hasil : ";
            // 
            // LabelOutput
            // 
            this.LabelOutput.AutoSize = true;
            this.LabelOutput.Location = new System.Drawing.Point(164, 142);
            this.LabelOutput.Name = "LabelOutput";
            this.LabelOutput.Size = new System.Drawing.Size(45, 16);
            this.LabelOutput.TabIndex = 8;
            this.LabelOutput.Text = "Output";
            // 
            // FormQuizPanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 205);
            this.Controls.Add(this.LabelOutput);
            this.Controls.Add(this.LabelHasil);
            this.Controls.Add(this.ButtonKonversi);
            this.Controls.Add(this.TextBoxHuruf2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TextBoxHuruf1);
            this.Controls.Add(this.LabelMasukkanHuruf);
            this.Controls.Add(this.TextBoxNama);
            this.Controls.Add(this.LabelMasukkanNama);
            this.Name = "FormQuizPanda";
            this.Text = "Quiz Panda";
            this.Load += new System.EventHandler(this.FormQuizPanda_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelMasukkanNama;
        private System.Windows.Forms.TextBox TextBoxNama;
        private System.Windows.Forms.Label LabelMasukkanHuruf;
        private System.Windows.Forms.TextBox TextBoxHuruf1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TextBoxHuruf2;
        private System.Windows.Forms.Button ButtonKonversi;
        private System.Windows.Forms.Label LabelHasil;
        private System.Windows.Forms.Label LabelOutput;
    }
}

