using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace GestionDesOffresDeStages
{
    public partial class Consulter : Form
    {

        public static MySqlConnection conn;

        public static DataSet ds = new DataSet();
        public static String variable1;
        public static int idOffreStage;
        
        int  id ;
        

        public Consulter()
        {
            InitializeComponent();
        }

        private void btFermer_Click(object sender, EventArgs e)
        {
            Form1 f  = new Form1();
            f.Show();
            this.Hide();
        }

        private void Consulter_Load(object sender, EventArgs e)
        {

            conn = new MySqlConnection("Server=127.0.0.1;User ID=root;Database=offre_stage; Password=;");
            conn.Open(); // on ouvre la connexion à la base 
            #region verification type profil
            string typeprofil;
            DbCommand cmdprofil = conn.CreateCommand();
            cmdprofil.CommandText = " SELECT tp.libelle from profil, type_profil tp where tp.idType=profil.Typeprofil AND profil.User='" + Authentifier.R1 + "';";
            cmdprofil.ExecuteScalar();
            typeprofil = (string)cmdprofil.ExecuteScalar();
            if (typeprofil == "administrateur")
            {
                lbOuiNon.Visible = true;
                rbOui.Visible = true;
                rbNon.Visible = true;
                btConfirmer.Visible = true;
                btPostulant.Visible = true;
            }
            #endregion
            #region Variables

            string variable2;
            string variable3;
            string variable4;
            string variable5;
            //string variable6;
            string variable7;
            string variable8;
            
           

            
            
            #endregion
            
            #region Requetes consulter

            id = 1;
                
            DbCommand cmd = conn.CreateCommand();
            cmd.CommandText = " SELECT raisonSociale from entreprise e, offrestage o where e.idEntreprise = o.idEntreprise AND idOffreStage='" + id + "'AND valide=' oui ';";
            cmd.ExecuteScalar();
            variable1 = (string)cmd.ExecuteScalar();
            tbNom.Text = variable1;



            cmd.CommandText = " SELECT adresseVille from entreprise e,offrestage o where e.idEntreprise = o.idEntreprise AND idOffreStage='" + id + "'AND valide=' oui ';";
            cmd.ExecuteScalar();
            variable2 = (string)cmd.ExecuteScalar();
            tbVille.Text = variable2;

            cmd.CommandText = " SELECT Mail from entreprise e, offrestage o where  e.idEntreprise = o.idEntreprise AND idOffreStage='" + id + "'AND valide=' oui ';";
            cmd.ExecuteScalar();
            variable3 = (string)cmd.ExecuteScalar();
            tbContact.Text = variable3;

            cmd.CommandText = " SELECT domaine from offrestage where idOffreStage='" + id + "'AND valide=' oui ';";
            cmd.ExecuteScalar();
            variable4 = (string)cmd.ExecuteScalar();
            tbDomaine.Text = variable4;

            cmd.CommandText = " SELECT libelle from offrestage where idOffreStage='" + id + "'AND valide=' oui ';";
            cmd.ExecuteScalar();
            variable5 = (string)cmd.ExecuteScalar();
            tbLibelle.Text = variable5;

            //cmd.CommandText = " SELECT dateDebut from offrestage where idOffreStage='" + id + "'AND valide=' oui ';";
            //cmd.ExecuteScalar();
            //variable6 = (string)cmd.ExecuteScalar();
            //tbDeb.Text = variable6;

            cmd.CommandText = " SELECT durée from offrestage where idOffreStage='" + id + "'AND valide=' oui ';";
            cmd.ExecuteScalar();
            variable7 = (string)cmd.ExecuteScalar();
            tbDuree.Text = variable7;

            cmd.CommandText = " SELECT descriptif from offrestage where idOffreStage='" + id + "'AND valide=' oui ';";
            cmd.ExecuteScalar();
            variable8= (string)cmd.ExecuteScalar();
            rtbDesc.Text = variable8;

           
            

            #endregion
        }

        private void btSuivant_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection("Server=127.0.0.1;User ID=root;Database=offre_stage; Password=;");
            conn.Open(); // on ouvre la connexion à la base 
            #region Variables
            string variable1;
            string variable2;
            string variable3;
            string variable4;
            string variable5;
            //string variable6;
            string variable7;
            string variable8;


            #endregion

            #region Requetes consulter

            id++;

            DbCommand cmd = conn.CreateCommand();
            cmd.CommandText = " SELECT raisonSociale from entreprise e, offrestage o where e.idEntreprise = o.idEntreprise AND idOffreStage='" + id + "';";
            cmd.ExecuteScalar();
            variable1 = (string)cmd.ExecuteScalar();
            tbNom.Text = variable1;

            cmd.CommandText = " SELECT adresseVille from entreprise e,offrestage o where e.idEntreprise = o.idEntreprise AND idOffreStage='" + id + "';";
            cmd.ExecuteScalar();
            variable2 = (string)cmd.ExecuteScalar();
            tbVille.Text = variable2;

            cmd.CommandText = " SELECT Mail from entreprise e, offrestage o where  e.idEntreprise = o.idEntreprise AND idOffreStage='" + id + "';";
            cmd.ExecuteScalar();
            variable3 = (string)cmd.ExecuteScalar();
            tbContact.Text = variable3;

            cmd.CommandText = " SELECT domaine from offrestage where idOffreStage='" + id + "';";
            cmd.ExecuteScalar();
            variable4 = (string)cmd.ExecuteScalar();
            tbDomaine.Text = variable4;

            cmd.CommandText = " SELECT libelle from offrestage where idOffreStage='" + id + "';";
            cmd.ExecuteScalar();
            variable5 = (string)cmd.ExecuteScalar();
            tbLibelle.Text = variable5;

            //cmd.CommandText = " SELECT dateDebut from offrestage where idOffreStage='" + id + "'AND valide=' oui ';";
            //cmd.ExecuteScalar();
            //variable6 = (string)cmd.ExecuteScalar();
            //tbDeb.Text = variable6;

            cmd.CommandText = " SELECT durée from offrestage where idOffreStage='" + id + "';";
            cmd.ExecuteScalar();
            variable7 = (string)cmd.ExecuteScalar();
            tbDuree.Text = variable7;

            cmd.CommandText = " SELECT descriptif from offrestage where idOffreStage='" + id + "';";
            cmd.ExecuteScalar();
            variable8 = (string)cmd.ExecuteScalar();
            rtbDesc.Text = variable8;


            #endregion
        }

        private void btPrecedent_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection("Server=127.0.0.1;User ID=root;Database=offre_stage; Password=;");
            conn.Open(); // on ouvre la connexion à la base 
            #region Variables
            string variable1;
            string variable2;
            string variable3;
            string variable4;
            string variable5;
            //string variable6;
            string variable7;
            string variable8;


            #endregion

            #region Requetes consulter

            id--;

            DbCommand cmd = conn.CreateCommand();
            cmd.CommandText = " SELECT raisonSociale from entreprise e, offrestage o where e.idEntreprise = o.idEntreprise AND idOffreStage='" + id + "';";
            cmd.ExecuteScalar();
            variable1 = (string)cmd.ExecuteScalar();
            tbNom.Text = variable1;

            cmd.CommandText = " SELECT adresseVille from entreprise e,offrestage o where e.idEntreprise = o.idEntreprise AND idOffreStage='" + id + "';";
            cmd.ExecuteScalar();
            variable2 = (string)cmd.ExecuteScalar();
            tbVille.Text = variable2;

            cmd.CommandText = " SELECT Mail from entreprise e, offrestage o where  e.idEntreprise = o.idEntreprise AND idOffreStage='" + id + "';";
            cmd.ExecuteScalar();
            variable3 = (string)cmd.ExecuteScalar();
            tbContact.Text = variable3;

            cmd.CommandText = " SELECT domaine from offrestage where idOffreStage='" + id + "';";
            cmd.ExecuteScalar();
            variable4 = (string)cmd.ExecuteScalar();
            tbDomaine.Text = variable4;

            cmd.CommandText = " SELECT libelle from offrestage where idOffreStage='" + id + "';";
            cmd.ExecuteScalar();
            variable5 = (string)cmd.ExecuteScalar();
            tbLibelle.Text = variable5;

            //cmd.CommandText = " SELECT dateDebut from offrestage where idOffreStage='" + id + "'AND valide=' oui ';";
            //cmd.ExecuteScalar();
            //variable6 = (string)cmd.ExecuteScalar();
            //tbDeb.Text = variable6;

            cmd.CommandText = " SELECT durée from offrestage where idOffreStage='" + id + "';";
            cmd.ExecuteScalar();
            variable7 = (string)cmd.ExecuteScalar();
            tbDuree.Text = variable7;

            cmd.CommandText = " SELECT descriptif from offrestage where idOffreStage='" + id + "';";
            cmd.ExecuteScalar();
            variable8 = (string)cmd.ExecuteScalar();
            rtbDesc.Text = variable8;


            #endregion
        }

        private void btPostuler_Click(object sender, EventArgs e)
        {
            
            #region recuperation des information de la personne connecté
            #region variable postuler
            string nom;
            string prenom;
            string mail;
            string cv;
            string raisonSociale;

            #endregion
            DbCommand cmd = conn.CreateCommand();

            cmd.CommandText = " SELECT nom from profil where User='" + Authentifier.R1 + "';";
            cmd.ExecuteScalar();
            nom = (string)cmd.ExecuteScalar();

            cmd.CommandText = " SELECT prenom from profil where User='" + Authentifier.R1 + "';";
            cmd.ExecuteScalar();
            prenom = (string)cmd.ExecuteScalar();

            cmd.CommandText = " SELECT mail from profil where User='" + Authentifier.R1 + "';";
            cmd.ExecuteScalar();
            mail = (string)cmd.ExecuteScalar();

            cmd.CommandText = " SELECT cv from profil where User='" + Authentifier.R1 + "';";
            cmd.ExecuteScalar();
            cv = (string)cmd.ExecuteScalar();
           

          
            raisonSociale = tbNom.Text;
            #endregion
            int R1;
            DbCommand cmdsociete = conn.CreateCommand();
            cmdsociete.CommandText = "SELECT idOffreStage FROM offrestage where laSociété = '" + raisonSociale + "' ;";
            R1 = (int)cmdsociete.ExecuteScalar();
            bdd.Postuler(nom,prenom,mail,cv,R1,' ',raisonSociale);
            MessageBox.Show(" Candidature enregistrée");
        }

        private void btConfirmer_Click(object sender, EventArgs e)
        {
            if (rbNon.Checked == true)
            {
                conn = new MySqlConnection("Server=127.0.0.1;User ID=root;Database=offre_stage; Password=;");
                conn.Open(); // on ouvre la connexion à la base

               string raisonSociale = tbNom.Text;
                DbCommand cmdfait = conn.CreateCommand();
                cmdfait.CommandText = "UPDATE OFFRESTAGE SET valide='non' WHERE laSociété = '" +raisonSociale  + "'";
                cmdfait.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            postuler p = new postuler();
            p.Show();
            
        }
    }
}
