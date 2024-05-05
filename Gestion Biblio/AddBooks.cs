using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Biblio
{
    public partial class AddBooks : Form
    {
        public AddBooks()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtBookName.Text!="" && txtAuthor.Text != "" && txtPublication.Text != "" && txtPrice.Text != "" && txtQuantity.Text != "")
            {

            
            string lnom = txtBookName.Text;
            string lauteur = txtAuthor.Text;
            string publication = txtPublication.Text;
            string pdate = dateTimePicker1.Text;
            Int64 prix = Int64.Parse(txtPrice.Text);
            Int64 quan = Int64.Parse(txtQuantity.Text);

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = .\\SQLEXPRESS; database = biblio;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "insert into NouveauLivre (lNom,lAuteur,lPubl,lPDate,lPrix,lQan) values ('" + lnom + "','" + lauteur + "','" + publication + "','" + pdate + "'," + prix + "," + quan + ")";
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Enregistrement des données.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtBookName.Clear();
            txtAuthor.Clear();
            txtPublication.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            }

            else
            {
                MessageBox.Show("Le champ vide n'est pas autorisé", "Avertissement", MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }

        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            if( MessageBox.Show("Cela supprimera vos données non enregistrées."," Êtes-vous sûr ?", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK )
            {
                this.Close();

            }
           
        }
    }
}
