using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionMatos
{
        public partial class FormConnexion : System.Windows.Forms.Form
        {
            public FormConnexion()
            {
                InitializeComponent();
            }

        string cnsql = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;";
  
        
        //btn_Submit Click event

        private void buttonConnexion_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "" || textBox_MDP.Text == "")
            {
                MessageBox.Show("Veuillez écrire vos identifiant");
                return;
            }
            try
            {
                //Create SqlConnection
                SqlConnection con = new SqlConnection(cnsql);
                SqlCommand cmd = new SqlCommand("Select * from Utilisateur where Nom_User=@username and Mdp=@password", con);
                cmd.Parameters.AddWithValue("@username", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@password", textBox_MDP.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                //If count is equal to 1, than show frmMain form
                if (count == 1)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Email ou Mot de Passe erroné");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormConnexion_Load(object sender, EventArgs e)
        {

        }
    }
}
