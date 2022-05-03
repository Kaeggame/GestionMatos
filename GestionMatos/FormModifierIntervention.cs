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
    public partial class FormulaireModifierIntervention : Form
    {
        public string NomIntervention;
        public string CommentaireIntervention;
        public string ClientIntervention;
        public string SiteIntervention;
        public string MaterielIntervention;
        public string TypeMaterielIntervention;
        public string DateIntervention;
        public string IDIntervention;

        public FormulaireModifierIntervention()
        {
            InitializeComponent();
        }

        // vraiment besoin d'explications ?
        private void buttonIModifierAnnuler_Click(object sender, EventArgs e)
        {
            this.Close(); // Je veux dire, VRAIMENT ?
        }

        private void FormulaireModifierIntervention_Load(object sender, EventArgs e)
        {
            this.textBoxIModifierNom.Text = this.NomIntervention;
            this.textBoxIModifierCommentaire.Text = this.CommentaireIntervention;
            this.textBoxIModifierClient.Text = this.ClientIntervention;
            this.textBoxIModifierSite.Text = this.SiteIntervention;
            this.textBoxIModifierMateriel.Text = this.MaterielIntervention;
            this.textBoxIModifierTypeMateriel.Text = this.TypeMaterielIntervention;
            this.textBoxIModifierDate.Text = this.DateIntervention;
        }

        private void buttonIModifier_Click(object sender, EventArgs e)
        {
            string cnsql = @"Server=.\SQLEXPRESS;Database=GestionMatos;Trusted_Connection=True;";
            SqlConnection sqlConn = new SqlConnection(cnsql);

            string query = "UPDATE Intervention SET InterDate = @InterDate,InterNom = @InterNom,Commentaire = @Commentaire where InterID = " + IDIntervention.ToString();
            SqlCommand cmd = new SqlCommand(query, sqlConn);
            cmd.Parameters.AddWithValue("@InterDate", textBoxIModifierDate.Text);
            cmd.Parameters.AddWithValue("@InterNom", textBoxIModifierNom.Text);
            cmd.Parameters.AddWithValue("@Commentaire", textBoxIModifierCommentaire.Text);
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
