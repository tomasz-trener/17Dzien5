﻿namespace P02ZadaniePogoda
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 192);
            this.Controls.Add(this.btnWczytajMiasta);
            this.Controls.Add(this.cbMiasta);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMiasta;
        private System.Windows.Forms.OpenFileDialog ofdPliki;
        private System.Windows.Forms.Button btnWczytajMiasta;
    }
}

