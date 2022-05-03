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
    public partial class FormulaireModifierClient : Form
    {
        public string NomClient;
        public string MailClient;
        public string TelClient;
        public string DescriptionClient;
        public string IDClient;


        public FormulaireModifierClient()
        {
            InitializeComponent();
        }

        // Nan vraiment, même un morveux de 4 piges comprend ce que ça fait
        private void buttonCModifierAnnuler_Click(object sender, EventArgs e)
        {
            this.Close(); // j'expliquerais pas ça sert à rien de demander 
        }

        private void FormulaireModifierClient_Load(object sender, EventArgs e)
        {

            string ModifierIDTestTest = this.IDClient;
            this.textBoxCModifierNom.Text = this.NomClient;
            this.textBoxCModifierMail.Text = this.MailClient;
            this.textBoxCModifierTel.Text = this.TelClient;
        }

        // Heu là c'est plus une bombe à retardement qu'autre choses... juste... n'y touchez pas... s'il vous plaît
        private void buttonCModifier_Click(object sender, EventArgs e)
        {
            string cnsql = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;";
            SqlConnection sqlConn = new SqlConnection(cnsql);

            string query = "UPDATE Client SET NomClient = @NomClient,Mail = @Mail,NumTel = @NumTel where ClientID = " + IDClient.ToString();
            SqlCommand cmd = new SqlCommand(query, sqlConn);
            cmd.Parameters.AddWithValue("@NomClient", textBoxCModifierNom.Text);
            cmd.Parameters.AddWithValue("@Mail", textBoxCModifierMail.Text);
            cmd.Parameters.AddWithValue("@NumTel", textBoxCModifierTel.Text);
            cmd.Connection.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error " + ex.Message);
            }
            Form.ActiveForm.Close(); // Ferme la fenetre actuelle apres la confirmation de la modification
            MessageBox.Show("Modification enregistrée");
            sqlConn.Close();
        }
            
       }
    }
