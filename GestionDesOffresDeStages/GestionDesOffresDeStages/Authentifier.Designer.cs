namespace GestionDesOffresDeStages
{
    partial class Authentifier
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
            this.btConnexion = new System.Windows.Forms.Button();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbMDP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btInscription = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btConnexion
            // 
            this.btConnexion.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btConnexion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btConnexion.Location = new System.Drawing.Point(182, 194);
            this.btConnexion.Name = "btConnexion";
            this.btConnexion.Size = new System.Drawing.Size(87, 27);
            this.btConnexion.TabIndex = 0;
            this.btConnexion.Text = "Connexion";
            this.btConnexion.UseVisualStyleBackColor = false;
            this.btConnexion.Click += new System.EventHandler(this.btConnexion_Click);
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(285, 65);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(116, 23);
            this.tbUser.TabIndex = 1;
            // 
            // tbMDP
            // 
            this.tbMDP.Location = new System.Drawing.Point(285, 125);
            this.tbMDP.Name = "tbMDP";
            this.tbMDP.PasswordChar = '*';
            this.tbMDP.Size = new System.Drawing.Size(116, 23);
            this.tbMDP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "identifiant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mot de Passe";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(432, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 27);
            this.button2.TabIndex = 5;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btInscription
            // 
            this.btInscription.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btInscription.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btInscription.Location = new System.Drawing.Point(302, 192);
            this.btInscription.Name = "btInscription";
            this.btInscription.Size = new System.Drawing.Size(87, 29);
            this.btInscription.TabIndex = 6;
            this.btInscription.Text = "S\'inscrire";
            this.btInscription.UseVisualStyleBackColor = false;
            this.btInscription.Click += new System.EventHandler(this.btInscription_Click);
            // 
            // Authentifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(687, 324);
            this.Controls.Add(this.btInscription);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMDP);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.btConnexion);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Authentifier";
            this.Text = "Authentifier";
            this.Load += new System.EventHandler(this.Authentifier_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btConnexion;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbMDP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btInscription;
    }
}