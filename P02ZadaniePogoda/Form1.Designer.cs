namespace P02ZadaniePogoda
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbMiasta = new System.Windows.Forms.ComboBox();
            this.ofdPliki = new System.Windows.Forms.OpenFileDialog();
            this.btnWczytajMiasta = new System.Windows.Forms.Button();
            this.btnPodajTemperature = new System.Windows.Forms.Button();
            this.lblRaport = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbCel = new System.Windows.Forms.RadioButton();
            this.rbFar = new System.Windows.Forms.RadioButton();
            this.rbKel = new System.Windows.Forms.RadioButton();
            this.pcObrazek = new System.Windows.Forms.PictureBox();
            this.pbClund = new System.Windows.Forms.PictureBox();
            this.pbSnow = new System.Windows.Forms.PictureBox();
            this.pbSun = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcObrazek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClund)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSun)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj miasto";
            // 
            // cbMiasta
            // 
            this.cbMiasta.FormattingEnabled = true;
            this.cbMiasta.Location = new System.Drawing.Point(12, 43);
            this.cbMiasta.Name = "cbMiasta";
            this.cbMiasta.Size = new System.Drawing.Size(174, 21);
            this.cbMiasta.TabIndex = 1;
            // 
            // ofdPliki
            // 
            this.ofdPliki.FileName = "openFileDialog1";
            // 
            // btnWczytajMiasta
            // 
            this.btnWczytajMiasta.Location = new System.Drawing.Point(192, 43);
            this.btnWczytajMiasta.Name = "btnWczytajMiasta";
            this.btnWczytajMiasta.Size = new System.Drawing.Size(119, 23);
            this.btnWczytajMiasta.TabIndex = 2;
            this.btnWczytajMiasta.Text = "Wczytaj inny plik";
            this.btnWczytajMiasta.UseVisualStyleBackColor = true;
            this.btnWczytajMiasta.Click += new System.EventHandler(this.btnWczytajMiasta_Click);
            // 
            // btnPodajTemperature
            // 
            this.btnPodajTemperature.Location = new System.Drawing.Point(12, 86);
            this.btnPodajTemperature.Name = "btnPodajTemperature";
            this.btnPodajTemperature.Size = new System.Drawing.Size(119, 23);
            this.btnPodajTemperature.TabIndex = 3;
            this.btnPodajTemperature.Text = "Podaj temperature";
            this.btnPodajTemperature.UseVisualStyleBackColor = true;
            this.btnPodajTemperature.Click += new System.EventHandler(this.btnPodajTemperature_Click);
            // 
            // lblRaport
            // 
            this.lblRaport.AutoSize = true;
            this.lblRaport.Location = new System.Drawing.Point(12, 124);
            this.lblRaport.Name = "lblRaport";
            this.lblRaport.Size = new System.Drawing.Size(35, 13);
            this.lblRaport.TabIndex = 4;
            this.lblRaport.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(137, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "w";
            // 
            // rbCel
            // 
            this.rbCel.AutoSize = true;
            this.rbCel.Checked = true;
            this.rbCel.Location = new System.Drawing.Point(158, 89);
            this.rbCel.Name = "rbCel";
            this.rbCel.Size = new System.Drawing.Size(32, 17);
            this.rbCel.TabIndex = 6;
            this.rbCel.TabStop = true;
            this.rbCel.Text = "C";
            this.rbCel.UseVisualStyleBackColor = true;
            // 
            // rbFar
            // 
            this.rbFar.AutoSize = true;
            this.rbFar.Location = new System.Drawing.Point(196, 89);
            this.rbFar.Name = "rbFar";
            this.rbFar.Size = new System.Drawing.Size(31, 17);
            this.rbFar.TabIndex = 7;
            this.rbFar.Text = "F";
            this.rbFar.UseVisualStyleBackColor = true;
            // 
            // rbKel
            // 
            this.rbKel.AutoSize = true;
            this.rbKel.Location = new System.Drawing.Point(233, 89);
            this.rbKel.Name = "rbKel";
            this.rbKel.Size = new System.Drawing.Size(32, 17);
            this.rbKel.TabIndex = 8;
            this.rbKel.Text = "K";
            this.rbKel.UseVisualStyleBackColor = true;
            // 
            // pcObrazek
            // 
            this.pcObrazek.Location = new System.Drawing.Point(291, 135);
            this.pcObrazek.Name = "pcObrazek";
            this.pcObrazek.Size = new System.Drawing.Size(68, 56);
            this.pcObrazek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcObrazek.TabIndex = 9;
            this.pcObrazek.TabStop = false;
            // 
            // pbClund
            // 
            this.pbClund.Image = global::P02ZadaniePogoda.Properties.Resources.clouds;
            this.pbClund.Location = new System.Drawing.Point(291, 197);
            this.pbClund.Name = "pbClund";
            this.pbClund.Size = new System.Drawing.Size(68, 56);
            this.pbClund.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbClund.TabIndex = 10;
            this.pbClund.TabStop = false;
            this.pbClund.Visible = false;
            // 
            // pbSnow
            // 
            this.pbSnow.Image = global::P02ZadaniePogoda.Properties.Resources.snow;
            this.pbSnow.Location = new System.Drawing.Point(291, 197);
            this.pbSnow.Name = "pbSnow";
            this.pbSnow.Size = new System.Drawing.Size(68, 56);
            this.pbSnow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSnow.TabIndex = 11;
            this.pbSnow.TabStop = false;
            this.pbSnow.Visible = false;
            // 
            // pbSun
            // 
            this.pbSun.BackColor = System.Drawing.Color.Transparent;
            this.pbSun.Image = global::P02ZadaniePogoda.Properties.Resources.sun;
            this.pbSun.Location = new System.Drawing.Point(291, 197);
            this.pbSun.Name = "pbSun";
            this.pbSun.Size = new System.Drawing.Size(68, 56);
            this.pbSun.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSun.TabIndex = 12;
            this.pbSun.TabStop = false;
            this.pbSun.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 330);
            this.Controls.Add(this.pbSun);
            this.Controls.Add(this.pbSnow);
            this.Controls.Add(this.pbClund);
            this.Controls.Add(this.pcObrazek);
            this.Controls.Add(this.rbKel);
            this.Controls.Add(this.rbFar);
            this.Controls.Add(this.rbCel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRaport);
            this.Controls.Add(this.btnPodajTemperature);
            this.Controls.Add(this.btnWczytajMiasta);
            this.Controls.Add(this.cbMiasta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pcObrazek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbClund)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSnow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMiasta;
        private System.Windows.Forms.OpenFileDialog ofdPliki;
        private System.Windows.Forms.Button btnWczytajMiasta;
        private System.Windows.Forms.Button btnPodajTemperature;
        private System.Windows.Forms.Label lblRaport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbCel;
        private System.Windows.Forms.RadioButton rbFar;
        private System.Windows.Forms.RadioButton rbKel;
        private System.Windows.Forms.PictureBox pcObrazek;
        private System.Windows.Forms.PictureBox pbClund;
        private System.Windows.Forms.PictureBox pbSnow;
        private System.Windows.Forms.PictureBox pbSun;
    }
}

