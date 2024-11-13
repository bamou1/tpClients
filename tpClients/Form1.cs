using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
namespace tpClients
{
    public partial class Form1 : Form
    {
        static string chaine = @"Data Source=DESKTOP-P9RAL23\SQLEXPRESS;Initial Catalog=db_banque;Integrated Security=True;Trust Server Certificate=True";
        SqlConnection cnx = new SqlConnection(chaine);
        SqlCommand cmd = null;
        DataTable dtClients = new DataTable();
        int cpt = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnx.Open();
            charger();

        }

        private void charger()
        {
            dtClients.Clear();
            cmd = new SqlCommand("select * from clients", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            dtClients.Load(dr);
            gridClients.DataSource = dtClients;
            dr.Close();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            if (valider())
            {
                cmd = new SqlCommand("select count(*) as nombre from clients where cin=@cin", cnx);
                cmd.Parameters.AddWithValue("@cin", txtCin.Text.ToUpper());
                int nb = int.Parse(cmd.ExecuteScalar().ToString());
                if (nb == 0)
                {
                    cmd = new SqlCommand("insert into clients values(@cin,@nom,@prenom,@telephone)", cnx);
                    cmd.Parameters.AddWithValue("@cin", txtCin.Text.ToUpper());
                    cmd.Parameters.AddWithValue("@nom", txtNom.Text);
                    cmd.Parameters.AddWithValue("@telephone", txtTelephone.Text);
                    cmd.Parameters.AddWithValue("@prenom", txtPrenom.Text);
                    cmd.ExecuteNonQuery();
                    charger();
                    vider();
                }
                else MessageBox.Show(txtCin.Text + "Deja Existe !!!");











            }
            else MessageBox.Show("Verfier les champs");

        }

        private void vider()
        {
            txtCin.Text = txtNom.Text = txtPrenom.Text = txtTelephone.Text = null;
            txtCin.Enabled = true;
        }

        public bool valider()
        {
            bool valid = false;
            if (txtCin.Text != ""
                && txtNom.Text != ""
                && txtPrenom.Text != ""
                && txtTelephone.Text != "")
            {
                valid = true;
            }

            return valid;
        }

        private void gridClients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = gridClients.CurrentCell.RowIndex;
            txtCin.Text = gridClients.Rows[index].Cells[0].Value.ToString();
            txtCin.Enabled = false;
            txtNom.Text = gridClients.Rows[index].Cells[1].Value.ToString();
            txtPrenom.Text = gridClients.Rows[index].Cells[2].Value.ToString();
            txtTelephone.Text = gridClients.Rows[index].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (valider())
            {
                cmd = new SqlCommand("update clients set nom=@nom,prenom=@prenom, telephone=@telephone where cin=@cin", cnx);
                cmd.Parameters.AddWithValue("@cin", txtCin.Text.ToUpper());
                cmd.Parameters.AddWithValue("@nom", txtNom.Text);
                cmd.Parameters.AddWithValue("@telephone", txtTelephone.Text);
                cmd.Parameters.AddWithValue("@prenom", txtPrenom.Text);
                cmd.ExecuteNonQuery();
                charger();
                vider();

            }
            else MessageBox.Show("Verfier les champs");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to delete?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                int index = gridClients.CurrentCell.RowIndex;
                string cin = gridClients.Rows[index].Cells[0].Value.ToString();
                cmd = new SqlCommand("delete from clients where cin=@cin", cnx);
                cmd.Parameters.AddWithValue("@cin", cin);
                cmd.ExecuteNonQuery();
                charger();



            }

        }


        public void naviger()
        {
            txtCin.Text = dtClients.Rows[cpt][0].ToString();
            txtNom.Text = dtClients.Rows[cpt][1].ToString();
            txtPrenom.Text = dtClients.Rows[cpt][2].ToString();
            txtTelephone.Text = dtClients.Rows[cpt][3].ToString();
           // gridClients.SelectedRows.Clear();
           // gridClients.Rows[cpt].Selected=true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cpt = 0;
            naviger();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (cpt < dtClients.Rows.Count - 1)
            {
                cpt++;
                naviger();
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cpt > 0)
            {
                cpt--;

                naviger();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cpt = dtClients.Rows.Count - 1;
            naviger();
        }
    }
}
