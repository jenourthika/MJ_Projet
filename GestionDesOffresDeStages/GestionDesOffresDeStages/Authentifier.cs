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
    public partial class Authentifier : Form
    {
        public static MySqlConnection conn;
        public static String R1;
        public static String R2;
     
        public Authentifier()
        {
            InitializeComponent();

        }

        private void btConnexion_Click(object sender, EventArgs e)
        {
            conn = new MySqlConnection("Server=127.0.0.1;User ID=root;Database=offre_stage; Password=;");
            conn.Open(); // on ouvre la connexion à la base 
            DbCommand cmd = conn.CreateCommand();
            DbCommand cmd1 = conn.CreateCommand();
            cmd.CommandText =  "Select USER from profil where user = '"+tbUser.Text+"';";
            cmd1.CommandText = "Select MDP from profil where MDP ='"+ tbMDP.Text+"';";
            R1 = (String) cmd.ExecuteScalar();
            R2= (String) cmd1.ExecuteScalar();
         
            if (tbUser.Text == R1 && tbMDP.Text == R2)
            {
                Form1 f = new Form1();
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Erreur d'identification");
            }
        }

        private void btInscription_Click(object sender, EventArgs e)
        {
            inscription i = new inscription();
            i.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
