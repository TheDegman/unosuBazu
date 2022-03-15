
namespace unosuBazu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unosIme = new System.Windows.Forms.TextBox();
            this.unosPrezime = new System.Windows.Forms.TextBox();
            this.Upisani = new System.Windows.Forms.ListBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.Pregled = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.TraziIme = new System.Windows.Forms.TextBox();
            this.Pretrazi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prezime";
            // 
            // unosIme
            // 
            this.unosIme.Location = new System.Drawing.Point(147, 13);
            this.unosIme.Name = "unosIme";
            this.unosIme.Size = new System.Drawing.Size(100, 23);
            this.unosIme.TabIndex = 2;
            // 
            // unosPrezime
            // 
            this.unosPrezime.Location = new System.Drawing.Point(147, 43);
            this.unosPrezime.Name = "unosPrezime";
            this.unosPrezime.Size = new System.Drawing.Size(100, 23);
            this.unosPrezime.TabIndex = 3;
            // 
            // Upisani
            // 
            this.Upisani.FormattingEnabled = true;
            this.Upisani.ItemHeight = 15;
            this.Upisani.Location = new System.Drawing.Point(110, 180);
            this.Upisani.Name = "Upisani";
            this.Upisani.Size = new System.Drawing.Size(276, 169);
            this.Upisani.TabIndex = 4;
            // 
            // btnUnesi
            // 
            this.btnUnesi.Location = new System.Drawing.Point(503, 180);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(75, 23);
            this.btnUnesi.TabIndex = 5;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = true;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // Pregled
            // 
            this.Pregled.Location = new System.Drawing.Point(503, 229);
            this.Pregled.Name = "Pregled";
            this.Pregled.Size = new System.Drawing.Size(75, 23);
            this.Pregled.TabIndex = 6;
            this.Pregled.Text = "Pregled";
            this.Pregled.UseVisualStyleBackColor = true;
            this.Pregled.Click += new System.EventHandler(this.Pregled_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trazi";
            // 
            // TraziIme
            // 
            this.TraziIme.Location = new System.Drawing.Point(128, 388);
            this.TraziIme.Name = "TraziIme";
            this.TraziIme.Size = new System.Drawing.Size(100, 23);
            this.TraziIme.TabIndex = 8;
            // 
            // Pretrazi
            // 
            this.Pretrazi.Location = new System.Drawing.Point(503, 388);
            this.Pretrazi.Name = "Pretrazi";
            this.Pretrazi.Size = new System.Drawing.Size(75, 23);
            this.Pretrazi.TabIndex = 9;
            this.Pretrazi.Text = "Pretrazi";
            this.Pretrazi.UseVisualStyleBackColor = true;
            this.Pretrazi.Click += new System.EventHandler(this.Pretrazi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pretrazi);
            this.Controls.Add(this.TraziIme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Pregled);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.Upisani);
            this.Controls.Add(this.unosPrezime);
            this.Controls.Add(this.unosIme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox unosIme;
        private System.Windows.Forms.TextBox unosPrezime;
        private System.Windows.Forms.ListBox Upisani;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Button Pregled;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TraziIme;
        private System.Windows.Forms.Button Pretrazi;
    }
}

