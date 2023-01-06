
namespace JpwpGame
{
    partial class ZdrowieToJestTo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZdrowieToJestTo));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.postac = new System.Windows.Forms.PictureBox();
            this.Jedzenie1 = new System.Windows.Forms.PictureBox();
            this.samopoczuciestatus = new System.Windows.Forms.Label();
            this.kondycjastatus = new System.Windows.Forms.Label();
            this.Jedzenie2 = new System.Windows.Forms.PictureBox();
            this.Jedzenie3 = new System.Windows.Forms.PictureBox();
            this.zdrowiestatus = new System.Windows.Forms.Label();
            this.liczbadni = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.wyb1 = new System.Windows.Forms.PictureBox();
            this.wyb2 = new System.Windows.Forms.PictureBox();
            this.wyb3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Opis1 = new System.Windows.Forms.Label();
            this.Opis2 = new System.Windows.Forms.Label();
            this.Opis3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jedzenie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jedzenie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jedzenie3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.ruchTimer);
            // 
            // postac
            // 
            this.postac.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.postac.Image = ((System.Drawing.Image)(resources.GetObject("postac.Image")));
            this.postac.Location = new System.Drawing.Point(414, 503);
            this.postac.Name = "postac";
            this.postac.Size = new System.Drawing.Size(60, 60);
            this.postac.TabIndex = 0;
            this.postac.TabStop = false;
            this.postac.Click += new System.EventHandler(this.pictureBox1_Click);
            this.postac.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.postac_PreviewKeyDown);
            // 
            // Jedzenie1
            // 
            this.Jedzenie1.BackColor = System.Drawing.Color.Transparent;
            this.Jedzenie1.Location = new System.Drawing.Point(42, 299);
            this.Jedzenie1.Name = "Jedzenie1";
            this.Jedzenie1.Size = new System.Drawing.Size(98, 98);
            this.Jedzenie1.TabIndex = 1;
            this.Jedzenie1.TabStop = false;
            this.Jedzenie1.Tag = "food1";
            this.Jedzenie1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // samopoczuciestatus
            // 
            this.samopoczuciestatus.AutoSize = true;
            this.samopoczuciestatus.BackColor = System.Drawing.Color.Transparent;
            this.samopoczuciestatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.samopoczuciestatus.Location = new System.Drawing.Point(488, 70);
            this.samopoczuciestatus.Name = "samopoczuciestatus";
            this.samopoczuciestatus.Size = new System.Drawing.Size(227, 37);
            this.samopoczuciestatus.TabIndex = 3;
            this.samopoczuciestatus.Text = "Samopoczucie";
            // 
            // kondycjastatus
            // 
            this.kondycjastatus.AutoSize = true;
            this.kondycjastatus.BackColor = System.Drawing.Color.Transparent;
            this.kondycjastatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.kondycjastatus.Location = new System.Drawing.Point(488, 118);
            this.kondycjastatus.Name = "kondycjastatus";
            this.kondycjastatus.Size = new System.Drawing.Size(148, 37);
            this.kondycjastatus.TabIndex = 4;
            this.kondycjastatus.Text = "Kondycja";
            // 
            // Jedzenie2
            // 
            this.Jedzenie2.BackColor = System.Drawing.Color.Transparent;
            this.Jedzenie2.Location = new System.Drawing.Point(239, 299);
            this.Jedzenie2.Name = "Jedzenie2";
            this.Jedzenie2.Size = new System.Drawing.Size(98, 98);
            this.Jedzenie2.TabIndex = 5;
            this.Jedzenie2.TabStop = false;
            // 
            // Jedzenie3
            // 
            this.Jedzenie3.BackColor = System.Drawing.Color.Transparent;
            this.Jedzenie3.Location = new System.Drawing.Point(427, 299);
            this.Jedzenie3.Name = "Jedzenie3";
            this.Jedzenie3.Size = new System.Drawing.Size(98, 98);
            this.Jedzenie3.TabIndex = 6;
            this.Jedzenie3.TabStop = false;
            // 
            // zdrowiestatus
            // 
            this.zdrowiestatus.AutoSize = true;
            this.zdrowiestatus.BackColor = System.Drawing.Color.Transparent;
            this.zdrowiestatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zdrowiestatus.Location = new System.Drawing.Point(488, 23);
            this.zdrowiestatus.Name = "zdrowiestatus";
            this.zdrowiestatus.Size = new System.Drawing.Size(131, 37);
            this.zdrowiestatus.TabIndex = 2;
            this.zdrowiestatus.Text = "Zdrowie";
            this.zdrowiestatus.Click += new System.EventHandler(this.label1_Click);
            // 
            // liczbadni
            // 
            this.liczbadni.AutoSize = true;
            this.liczbadni.BackColor = System.Drawing.Color.Transparent;
            this.liczbadni.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.liczbadni.Location = new System.Drawing.Point(488, 183);
            this.liczbadni.Name = "liczbadni";
            this.liczbadni.Size = new System.Drawing.Size(107, 37);
            this.liczbadni.TabIndex = 7;
            this.liczbadni.Text = "Dzień ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(395, 579);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "https://icons8.com";
            // 
            // wyb1
            // 
            this.wyb1.Location = new System.Drawing.Point(40, 440);
            this.wyb1.Name = "wyb1";
            this.wyb1.Size = new System.Drawing.Size(100, 54);
            this.wyb1.TabIndex = 11;
            this.wyb1.TabStop = false;
            this.wyb1.Tag = "wyb1";
            // 
            // wyb2
            // 
            this.wyb2.Location = new System.Drawing.Point(239, 440);
            this.wyb2.Name = "wyb2";
            this.wyb2.Size = new System.Drawing.Size(100, 54);
            this.wyb2.TabIndex = 12;
            this.wyb2.TabStop = false;
            this.wyb2.Tag = "wyb2";
            // 
            // wyb3
            // 
            this.wyb3.Location = new System.Drawing.Point(425, 440);
            this.wyb3.Name = "wyb3";
            this.wyb3.Size = new System.Drawing.Size(100, 54);
            this.wyb3.TabIndex = 13;
            this.wyb3.TabStop = false;
            this.wyb3.Tag = "wyb3";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "menu";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_3);
            // 
            // Opis1
            // 
            this.Opis1.AutoSize = true;
            this.Opis1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Opis1.Location = new System.Drawing.Point(36, 171);
            this.Opis1.Name = "Opis1";
            this.Opis1.Size = new System.Drawing.Size(88, 20);
            this.Opis1.TabIndex = 15;
            this.Opis1.Text = "Opis 1 pola";
            // 
            // Opis2
            // 
            this.Opis2.AutoSize = true;
            this.Opis2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Opis2.Location = new System.Drawing.Point(36, 200);
            this.Opis2.Name = "Opis2";
            this.Opis2.Size = new System.Drawing.Size(88, 20);
            this.Opis2.TabIndex = 16;
            this.Opis2.Text = "Opis 2 pola";
            // 
            // Opis3
            // 
            this.Opis3.AutoSize = true;
            this.Opis3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Opis3.Location = new System.Drawing.Point(36, 229);
            this.Opis3.Name = "Opis3";
            this.Opis3.Size = new System.Drawing.Size(88, 20);
            this.Opis3.TabIndex = 17;
            this.Opis3.Text = "Opis 3 pola";
            // 
            // ZdrowieToJestTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(824, 601);
            this.Controls.Add(this.Opis3);
            this.Controls.Add(this.Opis2);
            this.Controls.Add(this.Opis1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.wyb3);
            this.Controls.Add(this.wyb2);
            this.Controls.Add(this.wyb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.liczbadni);
            this.Controls.Add(this.Jedzenie3);
            this.Controls.Add(this.Jedzenie2);
            this.Controls.Add(this.kondycjastatus);
            this.Controls.Add(this.samopoczuciestatus);
            this.Controls.Add(this.zdrowiestatus);
            this.Controls.Add(this.Jedzenie1);
            this.Controls.Add(this.postac);
            this.Name = "ZdrowieToJestTo";
            this.Text = "ZdrowieTojestTo!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dol);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gora);
            ((System.ComponentModel.ISupportInitialize)(this.postac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jedzenie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jedzenie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Jedzenie3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wyb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox postac;
        private System.Windows.Forms.PictureBox Jedzenie1;
        private System.Windows.Forms.Label samopoczuciestatus;
        private System.Windows.Forms.Label kondycjastatus;
        private System.Windows.Forms.PictureBox Jedzenie2;
        private System.Windows.Forms.PictureBox Jedzenie3;
        private System.Windows.Forms.Label zdrowiestatus;
        private System.Windows.Forms.Label liczbadni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox wyb1;
        private System.Windows.Forms.PictureBox wyb2;
        private System.Windows.Forms.PictureBox wyb3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Opis1;
        private System.Windows.Forms.Label Opis2;
        private System.Windows.Forms.Label Opis3;
    }
}