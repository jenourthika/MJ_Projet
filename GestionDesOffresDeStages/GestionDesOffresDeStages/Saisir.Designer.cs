﻿namespace GestionDesOffresDeStages
{
    partial class Saisir
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
            this.cbNom = new System.Windows.Forms.ComboBox();
            this.cbReseau = new System.Windows.Forms.ComboBox();
            this.tbLibelle = new System.Windows.Forms.TextBox();
            this.tbDuree = new System.Windows.Forms.TextBox();
            this.tbChemin = new System.Windows.Forms.TextBox();
            this.rtbOffre = new System.Windows.Forms.RichTextBox();
            this.btEnvoyer = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtOffre = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // cbNom
            // 
            this.cbNom.FormattingEnabled = true;
            this.cbNom.Items.AddRange(new object[] {
            "JMEntreprise",
            "SocieteJL",
            "TransportV"});
            this.cbNom.Location = new System.Drawing.Point(187, 54);
            this.cbNom.Name = "cbNom";
            this.cbNom.Size = new System.Drawing.Size(121, 21);
            this.cbNom.TabIndex = 0;
            // 
            // cbReseau
            // 
            this.cbReseau.FormattingEnabled = true;
            this.cbReseau.Location = new System.Drawing.Point(187, 106);
            this.cbReseau.Name = "cbReseau";
            this.cbReseau.Size = new System.Drawing.Size(121, 21);
            this.cbReseau.TabIndex = 1;
            // 
            // tbLibelle
            // 
            this.tbLibelle.Location = new System.Drawing.Point(187, 168);
            this.tbLibelle.Name = "tbLibelle";
            this.tbLibelle.Size = new System.Drawing.Size(186, 20);
            this.tbLibelle.TabIndex = 2;
            // 
            // tbDuree
            // 
            this.tbDuree.Location = new System.Drawing.Point(416, 220);
            this.tbDuree.Name = "tbDuree";
            this.tbDuree.Size = new System.Drawing.Size(116, 20);
            this.tbDuree.TabIndex = 4;
            // 
            // tbChemin
            // 
            this.tbChemin.Location = new System.Drawing.Point(259, 257);
            this.tbChemin.Name = "tbChemin";
            this.tbChemin.Size = new System.Drawing.Size(95, 20);
            this.tbChemin.TabIndex = 5;
            // 
            // rtbOffre
            // 
            this.rtbOffre.Location = new System.Drawing.Point(240, 330);
            this.rtbOffre.Name = "rtbOffre";
            this.rtbOffre.Size = new System.Drawing.Size(175, 96);
            this.rtbOffre.TabIndex = 6;
            this.rtbOffre.Text = "";
            // 
            // btEnvoyer
            // 
            this.btEnvoyer.Location = new System.Drawing.Point(211, 442);
            this.btEnvoyer.Name = "btEnvoyer";
            this.btEnvoyer.Size = new System.Drawing.Size(75, 23);
            this.btEnvoyer.TabIndex = 7;
            this.btEnvoyer.Text = "Envoyer";
            this.btEnvoyer.UseVisualStyleBackColor = true;
            this.btEnvoyer.Click += new System.EventHandler(this.btEnvoyer_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(391, 442);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btAnnuler.TabIndex = 8;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom de l\'entreprise";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Domaine de l\'offre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "libellé de l\'offre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Date de début de stage";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Durée";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Chemin de stockage de l\'offre de stage";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Descriptif de l\'offre";
            // 
            // dtOffre
            // 
            this.dtOffre.CustomFormat = "yyyy/MM/dd";
            this.dtOffre.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtOffre.Location = new System.Drawing.Point(145, 220);
            this.dtOffre.Name = "dtOffre";
            this.dtOffre.Size = new System.Drawing.Size(163, 20);
            this.dtOffre.TabIndex = 16;
            // 
            // Saisir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 491);
            this.Controls.Add(this.dtOffre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btEnvoyer);
            this.Controls.Add(this.rtbOffre);
            this.Controls.Add(this.tbChemin);
            this.Controls.Add(this.tbDuree);
            this.Controls.Add(this.tbLibelle);
            this.Controls.Add(this.cbReseau);
            this.Controls.Add(this.cbNom);
            this.Name = "Saisir";
            this.Text = "Saisir";
            this.Load += new System.EventHandler(this.Saisir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNom;
        private System.Windows.Forms.ComboBox cbReseau;
        private System.Windows.Forms.TextBox tbLibelle;
        private System.Windows.Forms.TextBox tbDuree;
        private System.Windows.Forms.TextBox tbChemin;
        private System.Windows.Forms.RichTextBox rtbOffre;
        private System.Windows.Forms.Button btEnvoyer;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.DateTimePicker dtOffre;
    }
}