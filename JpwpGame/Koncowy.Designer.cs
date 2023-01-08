
namespace JpwpGame
{
    partial class Koncowy
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
            this.Tytul = new System.Windows.Forms.Label();
            this.Linia1 = new System.Windows.Forms.Label();
            this.Linia2 = new System.Windows.Forms.Label();
            this.wynik = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.Button();
            this.wyjdz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tytul
            // 
            this.Tytul.AutoSize = true;
            this.Tytul.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Tytul.Location = new System.Drawing.Point(355, 51);
            this.Tytul.Name = "Tytul";
            this.Tytul.Size = new System.Drawing.Size(97, 37);
            this.Tytul.TabIndex = 0;
            this.Tytul.Text = "Tytuł";
            this.Tytul.Click += new System.EventHandler(this.label1_Click);
            // 
            // Linia1
            // 
            this.Linia1.AutoSize = true;
            this.Linia1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Linia1.Location = new System.Drawing.Point(357, 108);
            this.Linia1.Name = "Linia1";
            this.Linia1.Size = new System.Drawing.Size(100, 29);
            this.Linia1.TabIndex = 1;
            this.Linia1.Text = "Zdanie1";
            // 
            // Linia2
            // 
            this.Linia2.AutoSize = true;
            this.Linia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Linia2.Location = new System.Drawing.Point(357, 154);
            this.Linia2.Name = "Linia2";
            this.Linia2.Size = new System.Drawing.Size(106, 29);
            this.Linia2.TabIndex = 2;
            this.Linia2.Text = "Zdanie 2";
            this.Linia2.Click += new System.EventHandler(this.Linia2_Click);
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.wynik.Location = new System.Drawing.Point(357, 194);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(78, 29);
            this.wynik.TabIndex = 3;
            this.wynik.Text = "Ile dni";
            this.wynik.Click += new System.EventHandler(this.wynik_Click);
            // 
            // menu
            // 
            this.menu.Location = new System.Drawing.Point(362, 457);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(115, 63);
            this.menu.TabIndex = 4;
            this.menu.Text = "Menu";
            this.menu.UseVisualStyleBackColor = true;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // wyjdz
            // 
            this.wyjdz.Location = new System.Drawing.Point(362, 526);
            this.wyjdz.Name = "wyjdz";
            this.wyjdz.Size = new System.Drawing.Size(115, 63);
            this.wyjdz.TabIndex = 5;
            this.wyjdz.Text = "Wyjdź";
            this.wyjdz.UseVisualStyleBackColor = true;
            this.wyjdz.Click += new System.EventHandler(this.wyjdz_Click);
            // 
            // Koncowy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 601);
            this.Controls.Add(this.wyjdz);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.Linia2);
            this.Controls.Add(this.Linia1);
            this.Controls.Add(this.Tytul);
            this.Name = "Koncowy";
            this.Text = "Zdrowie to jest to!";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Koncowy_FormClosing);
            this.Load += new System.EventHandler(this.Koncowy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tytul;
        private System.Windows.Forms.Label Linia1;
        private System.Windows.Forms.Label Linia2;
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.Button menu;
        private System.Windows.Forms.Button wyjdz;
    }
}