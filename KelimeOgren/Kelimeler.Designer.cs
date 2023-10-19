namespace KelimeOgren
{
    partial class Kelimeler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kelimeler));
            this.label1 = new System.Windows.Forms.Label();
            this.TxtEN = new System.Windows.Forms.TextBox();
            this.TxtTR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LblSüre = new System.Windows.Forms.Label();
            this.LblKelime = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BtnBaslat = new System.Windows.Forms.Button();
            this.BtnPas = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnStat = new System.Windows.Forms.Button();
            this.BtnMenü = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "İngilizce:";
            // 
            // TxtEN
            // 
            this.TxtEN.Enabled = false;
            this.TxtEN.Location = new System.Drawing.Point(115, 32);
            this.TxtEN.Name = "TxtEN";
            this.TxtEN.Size = new System.Drawing.Size(232, 26);
            this.TxtEN.TabIndex = 2;
            // 
            // TxtTR
            // 
            this.TxtTR.Enabled = false;
            this.TxtTR.Location = new System.Drawing.Point(115, 76);
            this.TxtTR.Name = "TxtTR";
            this.TxtTR.Size = new System.Drawing.Size(232, 26);
            this.TxtTR.TabIndex = 1;
            this.TxtTR.TextChanged += new System.EventHandler(this.TxtTR_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Türkçe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(397, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Süre:";
            // 
            // LblSüre
            // 
            this.LblSüre.AutoSize = true;
            this.LblSüre.Location = new System.Drawing.Point(445, 35);
            this.LblSüre.Name = "LblSüre";
            this.LblSüre.Size = new System.Drawing.Size(27, 19);
            this.LblSüre.TabIndex = 5;
            this.LblSüre.Text = "90";
            // 
            // LblKelime
            // 
            this.LblKelime.AutoSize = true;
            this.LblKelime.Location = new System.Drawing.Point(445, 79);
            this.LblKelime.Name = "LblKelime";
            this.LblKelime.Size = new System.Drawing.Size(18, 19);
            this.LblKelime.TabIndex = 7;
            this.LblKelime.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kelime:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnBaslat);
            this.groupBox1.Controls.Add(this.BtnPas);
            this.groupBox1.Controls.Add(this.TxtEN);
            this.groupBox1.Controls.Add(this.LblKelime);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.LblSüre);
            this.groupBox1.Controls.Add(this.TxtTR);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(19, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 185);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // BtnBaslat
            // 
            this.BtnBaslat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBaslat.Location = new System.Drawing.Point(236, 127);
            this.BtnBaslat.Name = "BtnBaslat";
            this.BtnBaslat.Size = new System.Drawing.Size(127, 49);
            this.BtnBaslat.TabIndex = 9;
            this.BtnBaslat.Text = "BAŞLAT";
            this.BtnBaslat.UseVisualStyleBackColor = true;
            this.BtnBaslat.Click += new System.EventHandler(this.BtnBaslat_Click);
            // 
            // BtnPas
            // 
            this.BtnPas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPas.Location = new System.Drawing.Point(103, 127);
            this.BtnPas.Name = "BtnPas";
            this.BtnPas.Size = new System.Drawing.Size(127, 49);
            this.BtnPas.TabIndex = 8;
            this.BtnPas.Text = "PAS";
            this.BtnPas.UseVisualStyleBackColor = true;
            this.BtnPas.Click += new System.EventHandler(this.BtnPas_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnStat);
            this.groupBox2.Controls.Add(this.BtnMenü);
            this.groupBox2.Location = new System.Drawing.Point(508, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 185);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // BtnStat
            // 
            this.BtnStat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnStat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnStat.Location = new System.Drawing.Point(6, 99);
            this.BtnStat.Name = "BtnStat";
            this.BtnStat.Size = new System.Drawing.Size(159, 77);
            this.BtnStat.TabIndex = 6;
            this.BtnStat.Text = "İSTATİSTİKLER";
            this.BtnStat.UseVisualStyleBackColor = true;
            // 
            // BtnMenü
            // 
            this.BtnMenü.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMenü.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMenü.Location = new System.Drawing.Point(6, 16);
            this.BtnMenü.Name = "BtnMenü";
            this.BtnMenü.Size = new System.Drawing.Size(159, 77);
            this.BtnMenü.TabIndex = 5;
            this.BtnMenü.Text = "MENÜ";
            this.BtnMenü.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(654, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // Kelimeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(54)))), ((int)(((byte)(90)))));
            this.ClientSize = new System.Drawing.Size(700, 250);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.Name = "Kelimeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Öğren";
            this.Load += new System.EventHandler(this.KelimeAna_Load);
            this.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtEN;
        private System.Windows.Forms.TextBox TxtTR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LblSüre;
        private System.Windows.Forms.Label LblKelime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button BtnBaslat;
        private System.Windows.Forms.Button BtnPas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnStat;
        private System.Windows.Forms.Button BtnMenü;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

