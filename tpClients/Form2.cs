using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tpClients
{
    public partial class Form2 : Form
    {

        static string chaine = @"Data Source=DESKTOP-P9RAL23\SQLEXPRESS;Initial Catalog=db_banque;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection cnx = new SqlConnection(chaine);
        SqlCommand cmd = null;
        DataTable dtComptes = new DataTable();
        DataTable dtClients = new DataTable();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            cnx.Open();
            chargerComptes();
            chargerComboClients();

        }

        private void chargerComptes()
        {
            dtComptes.Clear();
            cmd = new SqlCommand("select * from comptes", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            dtComptes.Load(dr);
            gridCompte.DataSource = dtComptes;
            dr.Close();
        }

        private void chargerComboClients()
        {
            dtClients.Clear();
            cmd = new SqlCommand("select cin as salam ,nom + ' ' + prenom  as nomC from clients", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            dtClients.Load(dr);
            dr.Close();
            comboClient.DataSource = dtClients;
            comboClient.DisplayMember = "nomC";
            comboClient.ValueMember = "salam";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtSolde.Text!="")
            {
                cmd = new SqlCommand("insert into comptes(solde,cin,datecreation) values(@s,@c,@d)", cnx);
                cmd.Parameters.AddWithValue("@s", txtSolde.Text);
                cmd.Parameters.AddWithValue("@c", comboClient.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@d", dateCr.Value);
                cmd.ExecuteNonQuery();
                chargerComptes();

            }
        }
    }
}
