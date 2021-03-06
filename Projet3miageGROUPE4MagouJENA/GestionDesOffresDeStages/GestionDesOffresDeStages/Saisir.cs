﻿using System;
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
    public partial class Saisir : Form
    {
        public static MySqlConnection conn;

        public static DataSet ds = new DataSet();
        public static DateTime dateDebut;
        public Saisir()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Saisir_Load(object sender, EventArgs e)
        {

            conn = new MySqlConnection("Server=127.0.0.1;User ID=root;Database=offre_stage; Password=;");
            conn.Open(); // on ouvre la connexion à la base 
            string requete = "SELECT raisonSociale FROM entreprise ;";
            MySqlDataAdapter Donnee = new MySqlDataAdapter(requete, conn);
            DataSet BDD = new DataSet();
            Donnee.Fill(BDD, "entreprise");
            cbNom.DataSource = BDD.Tables["entreprise"];
            cbNom.DisplayMember = "raisonSociale";
            cbNom.ValueMember = "raisonSociale";


            string requete1 = "SELECT secteur FROM entreprise ;";
            MySqlDataAdapter Donnee1 = new MySqlDataAdapter(requete1, conn);
            DataSet BDD1 = new DataSet();
            Donnee1.Fill(BDD1, "entreprise");
            cbReseau.DataSource = BDD1.Tables["entreprise"];
            cbReseau.DisplayMember = "secteur";
            cbReseau.ValueMember = "secteur";
        }

        private void btEnvoyer_Click(object sender, EventArgs e)
        {
            //if (dateDebut > DateTime.Now)
            //{
            //        cbNom = cbNom.SelectedValue;
            if (cbNom.Text != "" && cbReseau.Text != "" && tbLibelle.Text != "" && rtbOffre.Text != "" && tbDuree.Text != "" && tbChemin.Text != "")
            {

                this.DialogResult = DialogResult.OK;
                int R1;
                string nom = cbNom.Text;
                string reseau = cbReseau.Text;
                string libelle = tbLibelle.Text;
                dateDebut = dtOffre.Value;
                string duree = tbDuree.Text;
                string chemin = tbChemin.Text;
                string offre = rtbOffre.Text;
                conn = new MySqlConnection("Server=127.0.0.1;User ID=root;Database=offre_stage; Password=;");
                conn.Open(); // on ouvre la connexion à la base 
                DbCommand cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT idEntreprise FROM entreprise where raisonSociale = '" + nom + "' ;";
            R1 = (int)cmd.ExecuteScalar();

                //entre les données dans la table offrestage fait appel à la classe bdd 
                bdd.SaisirOffre(' ', libelle, offre, reseau, dateDebut, duree, chemin,"Oui",nom,R1);
                MessageBox.Show(" votre offe a bien été ajoutée");
                Form1 f = new Form1();
                f.Show();
                this.Hide();

            }
            //        else
            //            MessageBox.Show(" Veuillez renseigner toutes les données");
            //    }
            //    else
            //    {
            //        MessageBox.Show("La date de votre offre est incorrecte.");
            //    }
            //}
        }

     
    }
}