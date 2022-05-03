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
            this.textBoxCModifierNom.Text = this.NomClient;
            this.textBoxCModifierMail.Text = this.MailClient;
            this.textBoxCModifierTel.Text = this.TelClient;
        }

        // Heu là c'est plus une bombe à retardement qu'autre choses... juste... n'y touchez pas... s'il vous plaît
        private void buttonCModifier_Click(object sender, EventArgs e)
        {
            /*
            string cnsql = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;";

            {
                string query = "UPDATE tbl_Items SET Name = @Name,Category=@Category,start = @start, end = @End,Description = @Description where ID = @ID ";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.Parameters.AddWithValue("@ID", txtID.Text);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Category", Category.Text);
                cmd.Parameters.AddWithValue("@start", txtStart.Text);
                cmd.Parameters.AddWithValue("@end", txtend.Text);
                cmd.Parameters.AddWithValue("@Description", txtDescription.Text);
                cmd.Connection.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                }

                catch (Exception ex)
                {
                    throw new Exception("Error " + ex.Message);
                }
            }
            */
            
        }
    }
}
