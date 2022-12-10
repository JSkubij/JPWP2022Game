
namespace JpwpGame
{
    partial class Pomoc
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
            this.powrot = new System.Windows.Forms.Button();
            this.tytul_pomoc = new System.Windows.Forms.Label();
            this.Opisgry = new System.Windows.Forms.Label();
            this.Tytulster = new System.Windows.Forms.Label();
            this.Tytulopis = new System.Windows.Forms.Label();
            this.steropis = new System.Windows.Forms.Label();
            this.Tytulporady = new System.Windows.Forms.Label();
            this.Opisporady = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // powrot
            // 
            this.powrot.Location = new System.Drawing.Point(368, 399);
            this.powrot.Name = "powrot";
            this.powrot.Size = new System.Drawing.Size(75, 23);
            this.powrot.TabIndex = 0;
            this.powrot.Text = "Powrót";
            this.powrot.UseVisualStyleBackColor = true;
            this.powrot.Click += new System.EventHandler(this.powrot_Click);
            // 
            // tytul_pomoc
            // 
            this.tytul_pomoc.AutoSize = true;
            this.tytul_pomoc.Location = new System.Drawing.Point(383, 47);
            this.tytul_pomoc.Name = "tytul_pomoc";
            this.tytul_pomoc.Size = new System.Drawing.Size(40, 13);
            this.tytul_pomoc.TabIndex = 1;
            this.tytul_pomoc.Text = "Pomoc";
            this.tytul_pomoc.Click += new System.EventHandler(this.tytul_pomoc_Click);
            // 
            // Opisgry
            // 
            this.Opisgry.AutoSize = true;
            this.Opisgry.Location = new System.Drawing.Point(355, 107);
            this.Opisgry.Name = "Opisgry";
            this.Opisgry.Size = new System.Drawing.Size(88, 13);
            this.Opisgry.TabIndex = 2;
            this.Opisgry.Text = "Tu wpisz opis gry";
            this.Opisgry.Click += new System.EventHandler(this.Opisgry_Click);
            // 
            // Tytulster
            // 
            this.Tytulster.AutoSize = true;
            this.Tytulster.Location = new System.Drawing.Point(374, 143);
            this.Tytulster.Name = "Tytulster";
            this.Tytulster.Size = new System.Drawing.Size(60, 13);
            this.Tytulster.TabIndex = 3;
            this.Tytulster.Text = "Sterowanie";
            // 
            // Tytulopis
            // 
            this.Tytulopis.AutoSize = true;
            this.Tytulopis.Location = new System.Drawing.Point(378, 77);
            this.Tytulopis.Name = "Tytulopis";
            this.Tytulopis.Size = new System.Drawing.Size(45, 13);
            this.Tytulopis.TabIndex = 4;
            this.Tytulopis.Text = "Opis gry";
            this.Tytulopis.Click += new System.EventHandler(this.Tytulopis_Click);
            // 
            // steropis
            // 
            this.steropis.AutoSize = true;
            this.steropis.Location = new System.Drawing.Point(355, 172);
            this.steropis.Name = "steropis";
            this.steropis.Size = new System.Drawing.Size(103, 13);
            this.steropis.TabIndex = 5;
            this.steropis.Text = "Tu wpisz sterowanie";
            // 
            // Tytulporady
            // 
            this.Tytulporady.AutoSize = true;
            this.Tytulporady.Location = new System.Drawing.Point(388, 208);
            this.Tytulporady.Name = "Tytulporady";
            this.Tytulporady.Size = new System.Drawing.Size(40, 13);
            this.Tytulporady.TabIndex = 6;
            this.Tytulporady.Text = "Porady";
            this.Tytulporady.Click += new System.EventHandler(this.Tytulporady_Click);
            // 
            // Opisporady
            // 
            this.Opisporady.AutoSize = true;
            this.Opisporady.Location = new System.Drawing.Point(365, 243);
            this.Opisporady.Name = "Opisporady";
            this.Opisporady.Size = new System.Drawing.Size(91, 13);
            this.Opisporady.TabIndex = 7;
            this.Opisporady.Text = "Tu wpisać porady";
            this.Opisporady.Click += new System.EventHandler(this.Opisporady_Click);
            // 
            // Pomoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Opisporady);
            this.Controls.Add(this.Tytulporady);
            this.Controls.Add(this.steropis);
            this.Controls.Add(this.Tytulopis);
            this.Controls.Add(this.Tytulster);
            this.Controls.Add(this.Opisgry);
            this.Controls.Add(this.tytul_pomoc);
            this.Controls.Add(this.powrot);
            this.Name = "Pomoc";
            this.Text = "Pomoc";
            this.Load += new System.EventHandler(this.Pomoc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button powrot;
        private System.Windows.Forms.Label tytul_pomoc;
        private System.Windows.Forms.Label Opisgry;
        private System.Windows.Forms.Label Tytulster;
        private System.Windows.Forms.Label Tytulopis;
        private System.Windows.Forms.Label steropis;
        private System.Windows.Forms.Label Tytulporady;
        private System.Windows.Forms.Label Opisporady;
    }
}