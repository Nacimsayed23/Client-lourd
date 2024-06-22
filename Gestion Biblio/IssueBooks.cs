using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Biblio
{
    public partial class IssueBooks : Form
    {
        public IssueBooks()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void IssueBooks_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = .\\SQLEXPRESS; database= biblio;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            cmd = new SqlCommand("select lNom from  NouveauLivre", con);
            SqlDataReader Sdr = cmd.ExecuteReader();

            while(Sdr.Read())
            {
                for(int i = 0; i < Sdr.FieldCount; i++)
                {
                    comboBoxBooks.Items.Add(Sdr.GetString(i));
                }
            }
            Sdr.Close();
            con.Close();
            
        }

        int count;

        private void btnRecherche_Click(object sender, EventArgs e)
        {
            if (txtEnrollement.Text != "")
            {
                string eid = txtEnrollement.Text;
                SqlConnection con = new SqlConnection();
                con.ConnectionString = "data source = .\\SQLEXPRESS; database= biblio;integrated security=True";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                con.Open();


                cmd.CommandText = "select * from NouveauEtudiant where enumero = @eid";
                cmd.Parameters.AddWithValue("@eid", eid);

                SqlDataAdapter DA = new SqlDataAdapter(cmd);
                DataSet DS = new DataSet();
                DA.Fill(DS);

                //---------------------------------------------------------------------------------------------------
                //code pour compter combien de livres ont été émis sur ce numéro d'inscription

                cmd.CommandText = "select count(etd_numero) from IRLivre where etd_numero = '"+eid+"' and livre_date_retourner is null";
                

                SqlDataAdapter DA1 = new SqlDataAdapter(cmd);
                DataSet DS1 = new DataSet();
                DA.Fill(DS1);

                count = int.Parse(DS1.Tables[0].Rows[0][0].ToString());
                //---------------------------------------------------------------------------------------------------



                if (DS.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = DS.Tables[0].Rows[0][1].ToString();
                    txtDepartement.Text = DS.Tables[0].Rows[0][3].ToString();
                    txtSemestre.Text = DS.Tables[0].Rows[0][4].ToString();
                    txtContact.Text = DS.Tables[0].Rows[0][5].ToString();
                    txtEmail.Text = DS.Tables[0].Rows[0][6].ToString();


                }
                else
                {
                    txtName.Clear();
                    txtDepartement.Clear();
                    txtSemestre.Clear();
                    txtContact.Clear();
                    txtEmail.Clear();
                    MessageBox.Show("Numéro d'inscription invalide"," Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
        }

        private void btsIssueBook_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                if(comboBoxBooks.SelectedIndex != -1)
                {
                    string numero = txtEnrollement.Text;
                    string enom = txtName.Text;
                    string edep = txtDepartement.Text;
                    string seme = txtSemestre.Text;
                    Int64 contact = Int64.Parse(txtContact.Text); 
                    string email = txtEmail.Text;
                    string livrenom = comboBoxBooks.Text;
                    string livredateprêt = dateTimePicker.Text;

                    string eid = txtEnrollement.Text;
                    SqlConnection con = new SqlConnection();
                    con.ConnectionString = "data source = .\\SQLEXPRESS; database= biblio;integrated security=True";
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = con;
                    con.Open();

                    cmd.CommandText = "insert into IRLivre (etd_numero,etd_nom,etd_dep ,etd_sem ,etd_contact ,etd_email ,livre_nom ,livre_date_prêt) values('"+numero+"','"+enom+"','"+edep+"','"+seme+"',"+contact+",'"+email+"','"+livrenom+"','"+livredateprêt+"')";
                    cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("Livre emprunté", "Succès",MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    MessageBox.Show("Sélectionner le livre ou le nombre de livres qui ont été empruntésé", "Aucun livre n'a été sélectionné", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
               
            }

            else
            {
                MessageBox.Show("Saisissez un numéro d'inscription valide", "Erreur", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void txtEnrollement_TextChanged(object sender, EventArgs e)
        {
            if(txtEnrollement.Text == "")
            {
                txtName.Clear();
                txtDepartement.Clear();
                txtSemestre.Clear();    
                txtContact.Clear();
                txtEmail.Clear();

            }
        }

        private void btnActualiser_Click(object sender, EventArgs e)
        {
            txtEnrollement.Clear();
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Êtes-vous sûr ?", "Confirmation", MessageBoxButtons.OKCancel,MessageBoxIcon.Warning)==DialogResult.OK)
            {
                this.Close();
            }
          
        }
    }
}
