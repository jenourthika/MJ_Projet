namespace GestionDesOffresDeStages
{
    partial class inscription
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
            this.btValider = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbMDP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCV = new System.Windows.Forms.TextBox();
            this.tbLM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btValider
            // 
            this.btValider.Location = new System.Drawing.Point(137, 279);
            this.btValider.Name = "btValider";
            this.btValider.Size = new System.Drawing.Size(75, 23);
            this.btValider.TabIndex = 0;
            this.btValider.Text = "Valider";
            this.btValider.UseVisualStyleBackColor = true;
            this.btValider.Click += new System.EventHandler(this.btValider_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(148, 51);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(100, 20);
            this.tbNom.TabIndex = 1;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(148, 98);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(100, 20);
            this.tbPrenom.TabIndex = 2;
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(148, 157);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(100, 20);
            this.tbUser.TabIndex = 3;
            // 
            // tbMDP
            // 
            this.tbMDP.Location = new System.Drawing.Point(148, 215);
            this.tbMDP.Name = "tbMDP";
            this.tbMDP.Size = new System.Drawing.Size(100, 20);
            this.tbMDP.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "User";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "MDP";
            // 
            // tbCV
            // 
            this.tbCV.Location = new System.Drawing.Point(293, 62);
            this.tbCV.Name = "tbCV";
            this.tbCV.Size = new System.Drawing.Size(100, 20);
            this.tbCV.TabIndex = 9;
            // 
            // tbLM
            // 
            this.tbLM.Location = new System.Drawing.Point(293, 157);
            this.tbLM.Name = "tbLM";
            this.tbLM.Size = new System.Drawing.Size(100, 20);
            this.tbLM.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "CV *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "lettre de motivation";
            // 
            // tbMail
            // 
            this.tbMail.Location = new System.Drawing.Point(286, 215);
            this.tbMail.Name = "tbMail";
            this.tbMail.Size = new System.Drawing.Size(100, 20);
            this.tbMail.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(333, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mail";
            // 
            // inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 324);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbMail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbLM);
            this.Controls.Add(this.tbCV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMDP);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.btValider);
            this.Name = "inscription";
            this.Text = "inscription";
            this.Load += new System.EventHandler(this.inscription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btValider;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbMDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCV;
        private System.Windows.Forms.TextBox tbLM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbMail;
        private System.Windows.Forms.Label label7;
    }
}