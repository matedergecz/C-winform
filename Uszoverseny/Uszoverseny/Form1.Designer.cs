﻿namespace Uszoverseny
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
            this.label2 = new System.Windows.Forms.Label();
            this.lstVersenyzok = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRajtszam = new System.Windows.Forms.TextBox();
            this.txtOrszag = new System.Windows.Forms.TextBox();
            this.txtIdoEredmeny = new System.Windows.Forms.TextBox();
            this.txtEletKor = new System.Windows.Forms.TextBox();
            this.txtGyoztesIdo = new System.Windows.Forms.TextBox();
            this.btnGyoztes = new System.Windows.Forms.Button();
            this.rchTxtGyoztes = new System.Windows.Forms.RichTextBox();
            this.btnBezar = new System.Windows.Forms.Button();
            this.btnAdatBe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(261, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "200 m-es pillangó úszás";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Résztvevők";
            // 
            // lstVersenyzok
            // 
            this.lstVersenyzok.FormattingEnabled = true;
            this.lstVersenyzok.Location = new System.Drawing.Point(117, 86);
            this.lstVersenyzok.Name = "lstVersenyzok";
            this.lstVersenyzok.Size = new System.Drawing.Size(150, 264);
            this.lstVersenyzok.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Rajtszám:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(282, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ország:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(282, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Időeredmény:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Életkor:";
            // 
            // txtRajtszam
            // 
            this.txtRajtszam.Location = new System.Drawing.Point(359, 86);
            this.txtRajtszam.Name = "txtRajtszam";
            this.txtRajtszam.Size = new System.Drawing.Size(100, 20);
            this.txtRajtszam.TabIndex = 7;
            // 
            // txtOrszag
            // 
            this.txtOrszag.Location = new System.Drawing.Point(359, 113);
            this.txtOrszag.Name = "txtOrszag";
            this.txtOrszag.Size = new System.Drawing.Size(100, 20);
            this.txtOrszag.TabIndex = 8;
            // 
            // txtIdoEredmeny
            // 
            this.txtIdoEredmeny.Location = new System.Drawing.Point(359, 139);
            this.txtIdoEredmeny.Name = "txtIdoEredmeny";
            this.txtIdoEredmeny.Size = new System.Drawing.Size(100, 20);
            this.txtIdoEredmeny.TabIndex = 9;
            // 
            // txtEletKor
            // 
            this.txtEletKor.Location = new System.Drawing.Point(359, 168);
            this.txtEletKor.Name = "txtEletKor";
            this.txtEletKor.Size = new System.Drawing.Size(100, 20);
            this.txtEletKor.TabIndex = 10;
            // 
            // txtGyoztesIdo
            // 
            this.txtGyoztesIdo.Location = new System.Drawing.Point(359, 279);
            this.txtGyoztesIdo.Name = "txtGyoztesIdo";
            this.txtGyoztesIdo.Size = new System.Drawing.Size(100, 20);
            this.txtGyoztesIdo.TabIndex = 11;
            // 
            // btnGyoztes
            // 
            this.btnGyoztes.Enabled = false;
            this.btnGyoztes.Location = new System.Drawing.Point(273, 276);
            this.btnGyoztes.Name = "btnGyoztes";
            this.btnGyoztes.Size = new System.Drawing.Size(75, 23);
            this.btnGyoztes.TabIndex = 12;
            this.btnGyoztes.Text = "Győztes";
            this.btnGyoztes.UseVisualStyleBackColor = true;
            this.btnGyoztes.Click += new System.EventHandler(this.btnGyoztes_Click);
            // 
            // rchTxtGyoztes
            // 
            this.rchTxtGyoztes.Location = new System.Drawing.Point(285, 305);
            this.rchTxtGyoztes.Name = "rchTxtGyoztes";
            this.rchTxtGyoztes.Size = new System.Drawing.Size(174, 86);
            this.rchTxtGyoztes.TabIndex = 13;
            this.rchTxtGyoztes.Text = "";
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(343, 397);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(75, 23);
            this.btnBezar.TabIndex = 14;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // btnAdatBe
            // 
            this.btnAdatBe.Location = new System.Drawing.Point(117, 376);
            this.btnAdatBe.Name = "btnAdatBe";
            this.btnAdatBe.Size = new System.Drawing.Size(121, 44);
            this.btnAdatBe.TabIndex = 15;
            this.btnAdatBe.Text = "Adatok beolvasása";
            this.btnAdatBe.UseVisualStyleBackColor = true;
            this.btnAdatBe.Click += new System.EventHandler(this.btnAdatBe_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdatBe);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.rchTxtGyoztes);
            this.Controls.Add(this.btnGyoztes);
            this.Controls.Add(this.txtGyoztesIdo);
            this.Controls.Add(this.txtEletKor);
            this.Controls.Add(this.txtIdoEredmeny);
            this.Controls.Add(this.txtOrszag);
            this.Controls.Add(this.txtRajtszam);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstVersenyzok);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Úszóverseny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lstVersenyzok;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRajtszam;
        private System.Windows.Forms.TextBox txtOrszag;
        private System.Windows.Forms.TextBox txtIdoEredmeny;
        private System.Windows.Forms.TextBox txtEletKor;
        private System.Windows.Forms.TextBox txtGyoztesIdo;
        private System.Windows.Forms.Button btnGyoztes;
        private System.Windows.Forms.RichTextBox rchTxtGyoztes;
        private System.Windows.Forms.Button btnBezar;
        private System.Windows.Forms.Button btnAdatBe;
    }
}

