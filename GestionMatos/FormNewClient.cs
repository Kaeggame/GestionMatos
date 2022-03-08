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
    public partial class FormulaireNewClient : Form
    {
        public FormulaireNewClient()
        {
            InitializeComponent();
        }

        private void buttonCAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormulaireNewClient_Load(object sender, EventArgs e)
        {

        }

        private void buttonCCreer_Click(object sender, EventArgs e)
        {
            string cnsql = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;";
            SqlConnection sqlConn = new SqlConnection(cnsql);

            //Query pour Créer un nouveau client
            string query = "INSERT INTO Client(Mail, NomClient, NumTel) VALUES (@Mail, @NomClient, @NumTel)";
            SqlCommand cmd = new SqlCommand(query, sqlConn);    
            cmd.Parameters.AddWithValue("@Mail", textBoxCMail.Text); 
            cmd.Parameters.AddWithValue("@NomClient", textBoxCNom.Text);
            cmd.Parameters.AddWithValue("@NumTel", textBoxCTel.Text);
            cmd.Connection.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
            //Fin de la query
            Form.ActiveForm.Close(); // Ferme la fenetre actuelle apres la confirmation de la modification
            MessageBox.Show("Création éffectuée");
            sqlConn.Close();
        }
    }
}
