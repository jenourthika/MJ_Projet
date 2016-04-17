namespace GestionDesOffresDeStages
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btCreer = new System.Windows.Forms.Button();
            this.btSaisir = new System.Windows.Forms.Button();
            this.btConsulter = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCreer
            // 
            this.btCreer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btCreer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btCreer.Location = new System.Drawing.Point(42, 142);
            this.btCreer.Name = "btCreer";
            this.btCreer.Size = new System.Drawing.Size(142, 27);
            this.btCreer.TabIndex = 0;
            this.btCreer.Text = "Créer une entreprise";
            this.btCreer.UseVisualStyleBackColor = false;
            this.btCreer.Click += new System.EventHandler(this.btCreer_Click);
            // 
            // btSaisir
            // 
            this.btSaisir.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btSaisir.Location = new System.Drawing.Point(374, 142);
            this.btSaisir.Name = "btSaisir";
            this.btSaisir.Size = new System.Drawing.Size(105, 27);
            this.btSaisir.TabIndex = 1;
            this.btSaisir.Text = "Saisir une offre";
            this.btSaisir.UseVisualStyleBackColor = false;
            this.btSaisir.Click += new System.EventHandler(this.btSaisir_Click);
            // 
            // btConsulter
            // 
            this.btConsulter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btConsulter.Location = new System.Drawing.Point(205, 142);
            this.btConsulter.Name = "btConsulter";
            this.btConsulter.Size = new System.Drawing.Size(132, 27);
            this.btConsulter.TabIndex = 2;
            this.btConsulter.Text = "Consulter les offres";
            this.btConsulter.UseVisualStyleBackColor = false;
            this.btConsulter.Click += new System.EventHandler(this.btConsulter_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(227, 213);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 27);
            this.button4.TabIndex = 3;
            this.button4.Text = "Annuler";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(91, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "GESTION DES OFFRES DE STAGE";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(15, 55);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(14, 15);
            this.lb1.TabIndex = 6;
            this.lb1.Text = "2";
            this.lb1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(554, 301);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btConsulter);
            this.Controls.Add(this.btSaisir);
            this.Controls.Add(this.btCreer);
            this.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCreer;
        private System.Windows.Forms.Button btSaisir;
        private System.Windows.Forms.Button btConsulter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb1;
    }
}

