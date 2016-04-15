using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GestionDesOffresDeStages
{
    public partial class inscription : Form
    {
        public static MySqlConnection conn;
        public static DataSet ds = new DataSet();
       
        public inscription()
        {
            InitializeComponent();
        }

        private void btValider_Click(object sender, EventArgs e)
        {
            if (tbNom.Text != "" && tbPrenom.Text != "" && tbUser.Text != "" && tbMDP.Text != "" && tbCV.Text != "" && tbMail.Text != "")
                {
                    
                    this.DialogResult = DialogResult.OK;
                    string nom = tbNom.Text;
                    string prenom = tbPrenom.Text;
                    string user = tbUser.Text;
                    string mdp = tbMDP.Text;
                    string cv = tbCV.Text;
                    string lm = tbLM.Text;
                    string mail = tbMail.Text;
                 
                    //entre les données dans la table profil fait appel à la classe bdd et utilise la methode inscription
                    bdd.Inscription(nom,prenom,user,mdp,' ',cv,lm,mail);
                    MessageBox.Show(" votre inscription a bien été pris en compte");

                    Authentifier aE = new Authentifier();
                    aE.Show();
                    this.Hide();

                }
                else
                    MessageBox.Show(" Veuillez renseigner toutes les données");
            }

        private void inscription_Load(object sender, EventArgs e)
        {

        }
        }

       
    }

