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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtEnrollement.Clear();
            txtDepartement.Clear();
            txtSemester.Clear();
            txtContact.Clear();
            //txtEmail.Clear();
            txtEmail.Text = " ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirmer?","Alerte", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();

            }
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text!="" && txtEnrollement.Text !="" && txtDepartement.Text !="" && txtSemester.Text != ""&& txtContact.Text != ""&& txtEmail.Text != "")
            {

            string nom = txtName.Text;
            string numero = txtEnrollement.Text;
            string departement = txtDepartement.Text;
            string semestre = txtSemester.Text;
            Int64 mobile = Int64.Parse(txtContact.Text);
            string email = txtEmail.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = .\\SQLEXPRESS; database = biblio;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            con.Open();
            cmd.CommandText = "insert into NouveauEtudiant(enom,enumero,edepartement,esemestre,contact,email) values('"+nom+"','"+numero+"','"+ departement + "','"+ semestre + "',"+mobile+",'"+email+"')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Données enregistrées !", "succès", MessageBoxButtons.OK,MessageBoxIcon.Information);
           
            }
            else
            {
                MessageBox.Show("Veuillez remplir les champs vides", "Suggérer", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}
