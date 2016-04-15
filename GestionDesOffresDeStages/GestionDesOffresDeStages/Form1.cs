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
    public partial class Form1 : Form
    {
        public static MySqlConnection conn;
        public static DataSet ds = new DataSet();
        public static DateTime tournoiSelection;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Authentifier a = new Authentifier();
            a.Show();
            this.Hide();
        }

        private void btCreer_Click(object sender, EventArgs e)
        {
            Creation ct = new Creation();
            ct.Show();
            this.Hide();
        }

        private void btSaisir_Click(object sender, EventArgs e)
        {
            Saisir s = new Saisir();
            s.Show();
            this.Hide();
        }

        private void btConsulter_Click(object sender, EventArgs e)
        {
            Consulter c = new Consulter();
            c.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("Server=127.0.0.1;User ID=root;Database=offre_stage; Password=;");
            conn.Open(); // on ouvre la connexion à la base 
            DbCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT TypeProfil FROM profil where User ='" + Authentifier.R1 + "'";
            String requete = (String)cmd.ExecuteScalar();
      
            
            if(lb1.Text==requete)
            {
                btSaisir.Visible = false;
                btCreer.Visible = false;
            }
        }
    }
}
