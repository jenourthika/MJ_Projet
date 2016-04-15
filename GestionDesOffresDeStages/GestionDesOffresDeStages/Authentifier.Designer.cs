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
            this.btConnexion.Location = new System.Drawing.Point(156, 168);
            this.btConnexion.Name = "btConnexion";
            this.btConnexion.Size = new System.Drawing.Size(75, 23);
            this.btConnexion.TabIndex = 0;
            this.btConnexion.Text = "Connexion";
            this.btConnexion.UseVisualStyleBackColor = true;
            this.btConnexion.Click += new System.EventHandler(this.btConnexion_Click);
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(244, 56);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(100, 20);
            this.tbUser.TabIndex = 1;
            // 
            // tbMDP
            // 
            this.tbMDP.Location = new System.Drawing.Point(244, 108);
            this.tbMDP.Name = "tbMDP";
            this.tbMDP.PasswordChar = '*';
            this.tbMDP.Size = new System.Drawing.Size(100, 20);
            this.tbMDP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(153, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "identifiant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mot de Passe";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(370, 168);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Quitter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btInscription
            // 
            this.btInscription.Location = new System.Drawing.Point(259, 166);
            this.btInscription.Name = "btInscription";
            this.btInscription.Size = new System.Drawing.Size(75, 25);
            this.btInscription.TabIndex = 6;
            this.btInscription.Text = "S\'inscrire";
            this.btInscription.UseVisualStyleBackColor = true;
            this.btInscription.Click += new System.EventHandler(this.btInscription_Click);
            // 
            // Authentifier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 281);
            this.Controls.Add(this.btInscription);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMDP);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.btConnexion);
            this.Name = "Authentifier";
            this.Text = "Authentifier";
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