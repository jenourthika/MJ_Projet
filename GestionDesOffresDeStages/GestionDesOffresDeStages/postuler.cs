using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDesOffresDeStages
{
    public partial class postuler : Form
    {
        public postuler()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btPostuler_Click(object sender, EventArgs e)
        {
            if (tbNom.Text != "" && tbPrenom.Text != "" && tbCV.Text != "" && tbLM.Text != "" && tbMail.Text != "")
            {

                this.DialogResult = DialogResult.OK;

                string nom = tbNom.Text;
                string Prenom = tbPrenom.Text;
                string mail = tbMail.Text;
                string CV = tbCV.Text;
                string LM = tbLM.Text;
                int idOffreStage = Consulter.idOffreStage;
                string raisonSociale = Consulter.variable1;
               
                //entre les données dans la table postulant fait appel à la classe bdd et utilise la methode Postuler
                bdd.Postuler(nom, Prenom, mail, CV, idOffreStage, ' ', raisonSociale);
                MessageBox.Show(" votre candidature a bien été pris en compte");
                Authentifier aE = new Authentifier();
                aE.Show();
                this.Hide();
            }
        }

        private void postuler_Load(object sender, EventArgs e)
        {
            MessageBox.Show(Consulter.variable1);
        }
    }
}
