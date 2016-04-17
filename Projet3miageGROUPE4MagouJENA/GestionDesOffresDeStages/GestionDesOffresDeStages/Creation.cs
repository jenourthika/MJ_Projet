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
    public partial class Creation : Form
    {
        public static MySqlConnection conn;
        public static DataSet ds = new DataSet();
        public static DateTime tournoiSelection;
        public Creation()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btEnvoyer_Click(object sender, EventArgs e)
        {
                         if (tbNom.Text != "" && tbVille.Text !=""&& tbPostal.Text !="" && tbAdresse.Text !=""&& tbMail.Text !=""&& tbTel.Text !=""&& tbSecteur.Text !="")
                {
                    
                    this.DialogResult = DialogResult.OK;
                    string nom = tbNom.Text;
                    string ville = tbVille.Text;
                    string postal = tbPostal.Text;
                    string adresse = tbAdresse.Text;
                    string mail = tbMail.Text;
                    string tel = tbTel.Text;
                    string secteur = tbSecteur.Text;
                 
                    //entre les données dans la table profil fait appel à la classe bdd et utilise la methode inscription
                    bdd.EnregistrerEntreprise(' ',nom,ville,adresse,postal,tel,secteur,mail);
                    MessageBox.Show("votre entreprise a bien été enregistrée");

                    Form1 f = new Form1();
                    f.Show();
                    this.Hide();

                }
                else
                    MessageBox.Show(" Veuillez renseigner toutes les données");
            }

        private void Creation_Load(object sender, EventArgs e)
        {

        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
        }
    }

