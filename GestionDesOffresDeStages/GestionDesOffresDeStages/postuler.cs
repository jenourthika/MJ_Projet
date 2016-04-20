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
    public partial class postuler : Form
    {
        public static MySqlConnection conn;

        public static DataSet dt = new DataSet();
        public static BindingSource bd = new BindingSource();
        public postuler()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn = new MySqlConnection("Server=127.0.0.1;User ID=root;Database=offre_stage; Password=;");
            conn.Open(); // on ouvre la connexion à la base 
            string requete = "SELECT Nom,Prenom,CV FROM postulant ;";
            MySqlDataAdapter Donnee = new MySqlDataAdapter(requete, conn);
            DataSet dTable = new DataSet();
            Donnee.Fill(dTable,"postulant");
            BindingSource bSource = new BindingSource();
            bSource.DataSource = dTable.Tables["postulant"];
            dataGridView1.DataSource = dTable;

            //dataGridView1.DataMember = "Nom";
            //dataGridView1.DataMember = "Prenom";
            //dataGridView1.DataMember = "CV";
            
        }


       



       
    }
}
