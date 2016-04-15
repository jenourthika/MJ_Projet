namespace GestionDesOffresDeStages
{
    partial class postuler
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
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.Mail = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btPostuler = new System.Windows.Forms.Button();
            this.tbCV = new System.Windows.Forms.TextBox();
            this.tbLM = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(188, 42);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 20);
            this.tbNom.TabIndex = 0;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(188, 98);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(100, 20);
            this.tbPrenom.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prenom";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(188, 145);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(100, 20);
            this.tbMail.TabIndex = 4;
            // 
            // Mail
            // 
            this.Mail.AutoSize = true;
            this.Mail.Location = new System.Drawing.Point(106, 152);
            this.Mail.Name = "Mail";
            this.Mail.Size = new System.Drawing.Size(26, 13);
            this.Mail.TabIndex = 5;
            this.Mail.Text = "Mail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CV *";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(356, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lettre de Motivation *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "* Obligatoire";
            // 
            // btPostuler
            // 
            this.btPostuler.Location = new System.Drawing.Point(283, 199);
            this.btPostuler.Name = "btPostuler";
            this.btPostuler.Size = new System.Drawing.Size(75, 23);
            this.btPostuler.TabIndex = 9;
            this.btPostuler.Text = "Postuler";
            this.btPostuler.UseVisualStyleBackColor = true;
            this.btPostuler.Click += new System.EventHandler(this.btPostuler_Click);
            // 
            // tbCV
            // 
            this.tbCV.Location = new System.Drawing.Point(470, 42);
            this.tbCV.Name = "tbCV";
            this.tbCV.Size = new System.Drawing.Size(100, 20);
            this.tbCV.TabIndex = 10;
            // 
            // tbLM
            // 
            this.tbLM.Location = new System.Drawing.Point(470, 105);
            this.tbLM.Name = "tbLM";
            this.tbLM.Size = new System.Drawing.Size(100, 20);
            this.tbLM.TabIndex = 11;
            // 
            // postuler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 261);
            this.Controls.Add(this.tbLM);
            this.Controls.Add(this.tbCV);
            this.Controls.Add(this.btPostuler);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Mail);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Name = "postuler";
            this.Text = "postuler";
            this.Load += new System.EventHandler(this.postuler_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label Mail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btPostuler;
        private System.Windows.Forms.TextBox tbCV;
        private System.Windows.Forms.TextBox tbLM;

    }
}