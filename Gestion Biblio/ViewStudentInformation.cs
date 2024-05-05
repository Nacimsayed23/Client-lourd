using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Gestion_Biblio
{
    public partial class ViewStudentInformation : Form
    {
        public ViewStudentInformation()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        } 

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearcheEnrollement_TextChanged(object sender, EventArgs e)
        {
            if(txtSearcheEnrollement.Text != " ")
            {
               

                

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = .\\SQLEXPRESS; database= biblio;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NouveauEtudiant where  enumero like '" + txtSearcheEnrollement.Text + "%'";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet(); 
                DA.Fill(DS);    
                
             dataGridView1.DataSource = DS.Tables[0];    
            }
              else
              {
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = .\\SQLEXPRESS; database= biblio;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "select * from NouveauEtudiant ";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                dataGridView1.DataSource = DS.Tables[0];




            }
        }

        private void ViewStudentInformation_Load(object sender, EventArgs e)
        {
           panel2.Visible = false;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = .\\SQLEXPRESS; database= biblio;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NouveauEtudiant "; 
            SqlDataAdapter DA =new SqlDataAdapter(cmd);
            DataSet DS =  new DataSet();
           DA.Fill(DS);

            dataGridView1.DataSource = DS.Tables[0];

        }

        int bid;
        Int64 rowid;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                bid = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());

            }
            panel2.Visible=true;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = .\\SQLEXPRESS; database= biblio;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NouveauEtudiant where etudiant = "+bid+"";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            rowid = Int64.Parse(DS.Tables[0].Rows[0][0].ToString());

            txtEnom.Text = DS.Tables[0].Rows[0][1].ToString();
            txtEnrollement.Text = DS.Tables[0].Rows[0][2].ToString();
            txtDepartement.Text = DS.Tables[0].Rows[0][3].ToString();
            txtSemestre.Text = DS.Tables[0].Rows[0][4].ToString();
            txtContact.Text = DS.Tables[0].Rows[0][5].ToString();
            txtEmail.Text = DS.Tables[0].Rows[0][6].ToString();


        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Les données seront mises à jour. Confirmer ?", "Succès", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                String enom = txtEnom.Text;
                String enumero = txtEnrollement.Text;
                String edepartement = txtDepartement.Text;
                String esemestre = txtSemestre.Text;
                Int64 contact = Int64.Parse(txtContact.Text);
                String email = txtEmail.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = .\\SQLEXPRESS; database= biblio;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "update NouveauEtudiant set enom = '" +enom+ "', enumero = '"+enumero+"',edepartement ='"+edepartement+"',esemestre='"+esemestre+"',contact='"+contact+"',email='"+email+"' where etudiant="+rowid+"";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                ViewStudentInformation_Load(this, null);
            }

            
           
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ViewStudentInformation_Load(this, null);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Les données seront supprimer. Confirmer ?", "Boîte de dialogue de confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                String enom = txtEnom.Text;
                String enumero = txtEnrollement.Text;
                String edepartement = txtDepartement.Text;
                String esemestre = txtSemestre.Text;
                Int64 contact = Int64.Parse(txtContact.Text);
                String email = txtEmail.Text;

                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = .\\SQLEXPRESS; database= biblio;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "delete NouveauEtudiant where etudiant=" + rowid + "";
                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                ViewStudentInformation_Load(this, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Les données non enregistrées seront perdues.","Êtes-vous sûr ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.Close();
            }
           
        }
    }

    
    
}

