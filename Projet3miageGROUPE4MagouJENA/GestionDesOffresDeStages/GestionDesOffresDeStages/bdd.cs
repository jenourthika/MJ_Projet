using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data.Common;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace GestionDesOffresDeStages
{
    class bdd
    {
        public static MySqlConnection conn;
       

        // Ici on initialise de la base de donnée avec la methode Initialize

        public static void Initialize()
        {
            conn = new MySqlConnection("Server=127.0.0.1;User ID=root;Database=offre_stage; Password=;");
            conn.Open(); // on ouvre la connexion à la base 

        }
        public static void Inscription(String Nom, String Prenom, String User, String MDP, int TypeProfil,String CV,String Mail)
        {

            conn = new MySqlConnection("Server=127.0.0.1;User ID=root;Database=offre_stage; Password=;");
            conn.Open(); // on ouvre la connexion à la base 
            DbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Insert into profil VALUES ('" + Nom + "','" + Prenom + "','" + User + "','" + MDP + "','2','" + CV + "','" + Mail + "');";
            cmd.ExecuteNonQuery();
        }
        public static void EnregistrerEntreprise(int idEntreprise, String raisonSociale, String adresseVille, String adresseRue, String adresseCodePostal, String telephone,String secteur,String Mail)
        {
            

            conn = new MySqlConnection("Server=127.0.0.1;User ID=root;Database=offre_stage; Password=;");
            conn.Open(); // on ouvre la connexion à la base 
            DbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Insert into entreprise VALUES ('','" + raisonSociale + "','" + adresseVille + "','" + adresseRue + "','" + adresseCodePostal + "','" + telephone + "','" + secteur + "','" + Mail+"');";
            cmd.ExecuteNonQuery();
        }
        public static void SaisirOffre(int idOffreStage, String libelle, String descriptif, String domaine, DateTime dateDebut, String durée, String chemin, String valide,String laSociete,int idEntreprise)
        {

            conn = new MySqlConnection("Server=127.0.0.1;User ID=root;Database=offre_stage; Password=;");
            conn.Open(); // on ouvre la connexion à la base 
            DbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Insert into offreStage VALUES (' ','" + libelle + "','" + descriptif + "','" + domaine + "','" + dateDebut.Date.ToString("yyyy/MM/dd") +"','" + durée + "','" + chemin + "','"+ valide +"','"+ laSociete +"','"+idEntreprise+"');";
            cmd.ExecuteNonQuery();
        }
        public static void Postuler(String nom, String prenom, String mail, String cv,  int idOffreStage, int idPostulant,String RaisonSociale)
        {
            conn = new MySqlConnection("Server=127.0.0.1;User ID=root;Database=offre_stage; Password=;");
            conn.Open(); // on ouvre la connexion à la base 
            DbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "Insert into Postulant VALUES('" + nom + "','" + prenom + "','" + mail + "','" + cv + "','"+ idOffreStage +"',' ','"+RaisonSociale+" ');";
            cmd.ExecuteNonQuery();




        }
    }
}
